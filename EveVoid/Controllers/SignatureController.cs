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
        public ActionResult InsertSignature(string mainToken, SignatureDto dto)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Pilot.Corporation.AllianceId != null ? main.Pilot.Corporation.Alliance.MaskId : main.Pilot.Corporation.MaskId;
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
            _signatureService.WormholeSigUpdate(dto, newSig, maskId);
            return Ok();
        }

        [HttpPut("UpdateSignature")]
        public ActionResult UpdateSignature(string mainToken, SignatureDto dto)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Pilot.Corporation.AllianceId != null ? main.Pilot.Corporation.Alliance.MaskId : main.Pilot.Corporation.MaskId;
            var sig = _signatureService.GetBySignatureId(dto.Id);
            sig.SignatureId = dto.SignatureId;
            //sig.ExpiryDate = dto.ExpiryDate;
            sig.Name = dto.Name;
            sig.SignatureType = dto.SignatureType;
            _signatureService.WormholeSigUpdate(dto, sig, maskId);
            return Ok();
        }

        [HttpDelete("")]
        public ActionResult DeleteSignature(int sigId)
        {
            _signatureService.Delete(sigId, commit: true);
            return Ok();
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
            var maskId = main.MaskType == MaskType.Alliance && main.Pilot.Corporation.AllianceId != null ? main.Pilot.Corporation.Alliance.MaskId : main.Pilot.Corporation.MaskId;
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
    }
}
