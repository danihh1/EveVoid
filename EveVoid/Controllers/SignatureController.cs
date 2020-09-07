using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using EveVoid.Dto;
using EveVoid.Models.Navigation;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Services.Navigation;
using EveVoid.Services.Navigation.MapObjects;
using EveVoid.Services.Pilots;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EveVoid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignatureController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISignatureService _signatureService;
        private readonly ICharacterService _characterService;
        private readonly ISolarSystemService _solarSystemService;

        public SignatureController(IMapper mapper,
            ISignatureService signatureService,
            ICharacterService characterService, 
            ISolarSystemService solarSystemService)
        {
            _mapper = mapper;
            _signatureService = signatureService;
            _characterService = characterService;
            _solarSystemService = solarSystemService;
        }

        [HttpPost("InsertSignature")]
        public void InsertSignature(string mainToken, SignatureDto dto)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Corporation.AllianceId != null ? main.Corporation.Alliance.MaskId : main.Corporation.MaskId;
            var newSig = new Signature
            {
                SignatureId = dto.SignatureId.ToUpper(),
                ExpiryDate = dto.ExpiryDate,
                Name = dto.Name,
                SignatureType = dto.SignatureType,
                MaskId = maskId,
                SystemId = dto.SystemId
            };
            _signatureService.Insert(newSig, commit: true);
            WormholeSigUpdate(dto, newSig, maskId);
        }

        [HttpPut("UpdateSignature")]
        public void UpdateSignature(string mainToken, SignatureDto dto)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Corporation.AllianceId != null ? main.Corporation.Alliance.MaskId : main.Corporation.MaskId;
            var sig = _signatureService.GetBySignatureId(dto.Id);
            sig.SignatureId = dto.SignatureId;
            sig.ExpiryDate = dto.ExpiryDate;
            sig.Name = dto.Name;
            sig.SignatureType = dto.SignatureType;
            WormholeSigUpdate(dto, sig, maskId);
        }

        [HttpDelete("")]
        public void DeleteSignature(int sigId)
        {
            _signatureService.Delete(sigId, commit: true);
        }

        [HttpGet("GetSignatureById")]
        public SignatureDto GetSignatureById(int id)
        {
            return _mapper.Map<SignatureDto>(_signatureService.GetBySignatureId(id));
        }

        [HttpGet("GetPossibleJumpSignatures")]
        public List<SignatureDto> GetPossibleJumpSignatures(string mainToken, int originId, int destoId)
        {
            var res = new List<SignatureDto>();
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Corporation.AllianceId != null ? main.Corporation.Alliance.MaskId : main.Corporation.MaskId;
            var originSystem = _solarSystemService.GetSystemById(originId);
            var destoSystem = _solarSystemService.GetSystemById(destoId);
            var originSigs = originSystem.Signatures.Where(x => x.MaskId == maskId).Select(x => x).ToList();
            var directConnection = originSigs.FirstOrDefault(x => x.Destination?.SystemId == destoId);
            if (directConnection != null)
            {
                res.Add(_mapper.Map<SignatureDto>(directConnection));
                return res;
            }
            var destoTypeMatchSigs = originSigs.Where(x => x.DestinationId == null && x.WormholeType?.LeadsToId == destoSystem.SystemTypeId).ToList();
            if (destoTypeMatchSigs.Count > 0)
            {
                res.AddRange(_mapper.Map<List<SignatureDto>>(destoTypeMatchSigs));
                return res;
            }
            var originWormholes = originSigs.Where(x => x.SignatureType == SignatureType.Wormhole && x.DestinationId == null).ToList();
            if (originWormholes.Count == 0)
            {
                originWormholes = originSigs.Where(x => x.SignatureType == SignatureType.Unknown && x.DestinationId == null).ToList();
            }
            res.AddRange(_mapper.Map<List<SignatureDto>>(originWormholes));
            return res;
        }

        [HttpGet("GetWormholeTypes")]
        public List<WormholeTypeDto> GetWormholeTypes()
        {
            return _mapper.Map<List<WormholeTypeDto>>(_signatureService.GetWormholeTypes());
        }

        private void WormholeSigUpdate(SignatureDto dto, Signature sig, int maskId)
        {
            if (dto.SignatureType == SignatureType.Wormhole)
            {
                sig.MassIndicator = dto.MassIndicator;
                if (sig.TimeRemainingIndicator != dto.TimeRemainingIndicator)
                {
                    switch (dto.TimeRemainingIndicator)
                    {
                        case TimeRemainingIndicator.EoL:
                            {
                                if (sig.ExpiryDate > DateTime.UtcNow.AddHours(4))
                                {
                                    sig.ExpiryDate = DateTime.UtcNow.AddHours(4);
                                }
                                break;
                            }
                        case TimeRemainingIndicator.Unset:
                            {
                                var baseHours = 24;
                                if (sig.WormholeType != null)
                                {
                                    baseHours = int.Parse(Regex.Replace(sig.WormholeType.Duration, "[^0-9]+", string.Empty));
                                    sig.ExpiryDate = sig.CreationDate.AddHours(baseHours);
                                }
                                break;
                            }
                    }
                }
                sig.TimeRemainingIndicator = dto.TimeRemainingIndicator;
                sig.WormholeTypeId = dto.WormholeTypeId;
                _signatureService.Update(sig);
                if (dto.DestinationSystemId.HasValue)
                {
                    if (sig.DestinationId.HasValue && sig.Destination.SystemId != dto.DestinationSystemId)
                    {
                        _signatureService.Delete(sig.DestinationId.Value);
                        sig.DestinationId = null;
                        _signatureService.Update(sig, commit: true);
                    }
                    var desto = _solarSystemService.GetSystemById(dto.DestinationSystemId.Value);
                    //sig.Name = desto.Name;
                    var destoSig = desto.Signatures.FirstOrDefault(x => x.Id == sig.DestinationId); // desto.Signatures.FirstOrDefault(x => x.MaskId == maskId && x.Destination?.SystemId == dto.SystemId);
                    if (destoSig == null)
                    {
                        destoSig = new Signature
                        {
                            SignatureId = "???",
                            ExpiryDate = sig.ExpiryDate,
                            Name = "",
                            SignatureType = SignatureType.Wormhole,
                            MaskId = maskId,
                            WormholeTypeId = _signatureService.GetByTypeName("????").Id
                        };
                        desto.Signatures.Add(destoSig);
                        _solarSystemService.UpdateSystem(desto);
                    }
                    if (dto.WormholeType != "K162" && dto.WormholeType != "????")
                    {
                        destoSig.WormholeTypeId = _signatureService.GetByTypeName("K162").Id;
                    }
                    sig.DestinationId = destoSig.Id;
                    destoSig.DestinationId = sig.Id;
                    destoSig.MassIndicator = sig.MassIndicator;
                    destoSig.TimeRemainingIndicator = sig.TimeRemainingIndicator;
                    destoSig.ExpiryDate = sig.ExpiryDate;
                    _solarSystemService.UpdateSystem(desto);
                }
                else
                {
                    if (sig.DestinationId.HasValue)
                    {
                        _signatureService.Delete(sig.DestinationId.Value);
                        sig.DestinationId = null;
                    }
                }
            }
            else
            {
                if (sig.DestinationId.HasValue)
                {
                    _signatureService.Delete(sig.DestinationId.Value);
                    sig.DestinationId = null;
                }
                sig.WormholeTypeId = null;
            }
            _signatureService.Update(sig, commit: true);
        }
    }
}
