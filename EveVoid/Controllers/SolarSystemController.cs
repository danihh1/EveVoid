using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EveVoid.Dto;
using EveVoid.Models.Navigation;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Models.Pilots;
using EveVoid.Services.Navigation;
using EveVoid.Services.Navigation.MapObjects;
using EveVoid.Services.Pilots;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EveVoid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolarSystemController : ControllerBase
    {
        private readonly ISolarSystemService _solarSystemService;
        private readonly ICharacterService _characterService;
        private readonly ISignatureService _signatureService;
        private readonly IMapper _mapper;

        public SolarSystemController(ISolarSystemService solarSystemService,
            ICharacterService characterService,
            IMapper mapper,
            ISignatureService signatureService)
        {
            _solarSystemService = solarSystemService;
            _characterService = characterService;
            _mapper = mapper;
            _signatureService = signatureService;
        }

        [HttpGet("GetSolarSystemById")]
        public SolarSystemDto GetSolarSystemById(string mainToken, int systemId)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Corporation.AllianceId != null ? main.Corporation.Alliance.MaskId : main.Corporation.MaskId;
            var system = _solarSystemService.GetSystemById(systemId);
            var res = _mapper.Map<SolarSystemDto>(system);
            res.Signatures = _mapper.Map<List<SignatureDto>>(system.Signatures.Where(x => x.MaskId == maskId));
            res.Pilots = _mapper.Map<List<ActivePilotDto>>(system.Pilots.Where(x => main.MaskType == MaskType.Corp ? (x.MainCharacter.Corporation.MaskId == maskId) :
                x.MainCharacter.Corporation.AllianceId != null && x.MainCharacter.Corporation.Alliance.MaskId == maskId));
            res.Notes = _mapper.Map<List<SolarSystemNoteDto>>(system.Notes.Where(x => x.MaskId == maskId));
            res.Tags = _mapper.Map<List<SolarSystemTagDto>>(system.Tags.Where(x => x.MaskId == maskId));
            res.Structures = _mapper.Map<List<SolarSystemStructureDto>>(system.Structures.Where(x => x.MaskId == maskId));
            res.IsFavorite = main.FavoriteSystems.Any(x => x.SolarSystemId == systemId);
            res.Dscans = system.Dscans.Where(x => x.MaskId == maskId).OrderByDescending(x => x.CreationDate).Select(x => new DscanDto
            {
                Id = x.Id,
                SolarSystemId = x.SolarSystemId,
                DscanShipGroups = x.DscanShips.GroupBy(s => s.ShipType.ItemGroup.Name).Select(s => new DscanShipGroupDto
                {
                    GroupName = s.Key,
                    GroupCount = s.Count(),
                    ShipTypes = s.GroupBy(r => r.ShipType.Name).ToDictionary(r => r.Key, r => r.Count())
                }).ToList(),
                CreationDate = x.CreationDate
            }).ToList();
            res.Dscans.ForEach(d => d.DscanShipGroups = d.DscanShipGroups.OrderByDescending(x => x.GroupCount).ToList());

            return res;
        }

        [HttpPut("UpdateSolarSystemSignatures")]
        public SolarSystemDto UpdateSolarSystemSignatures(string mainToken, SolarSystemDto dto)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Corporation.AllianceId != null ? main.Corporation.Alliance.MaskId : main.Corporation.MaskId;
            var system = _solarSystemService.GetSystemById(dto.Id);
            var dtoSigIds = dto.Signatures.Select(x => x.Id).ToHashSet();
            var systemSigIds = system.Signatures.Where(x => x.MaskId == maskId).Select(x => x.Id).ToHashSet();
            //to delete
            foreach (var toDeleteId in systemSigIds.Where(x => !dtoSigIds.Contains(x)).ToList())
            {
                var toDelete = _signatureService.GetBySignatureId(toDeleteId);
                if (toDelete.DestinationId != null)
                {
                    var destoSig = _signatureService.GetBySignatureId(toDelete.DestinationId.Value);
                    destoSig.DestinationId = null;
                    toDelete.DestinationId = null;
                    _signatureService.Update(destoSig);
                    _signatureService.Update(toDelete, commit: true);
                    _signatureService.Delete(destoSig.Id);
                }
                _signatureService.Delete(toDelete.Id, commit: true);
            }
            
            //to update or add
            foreach (var updateSig in dto.Signatures)
            {
                var systemSig = _signatureService.GetBySignatureId(updateSig.Id);
                if (systemSig == null)
                {
                    //create new sig
                    systemSig = new Signature
                    {
                        SignatureId = updateSig.SignatureId,
                        ExpiryDate = updateSig.ExpiryDate,
                        Name = updateSig.Name,
                        SignatureType = updateSig.SignatureType,
                        MaskId = maskId,
                        SystemId = dto.Id
                    };
                    system.Signatures.Add(systemSig);
                }
                else
                {
                    systemSig.SignatureId = updateSig.SignatureId;
                    systemSig.ExpiryDate = updateSig.ExpiryDate;
                    systemSig.Name = updateSig.Name;
                    systemSig.SignatureType = updateSig.SignatureType;
                }
                _solarSystemService.UpdateSystem(system);
                _signatureService.WormholeSigUpdate(updateSig, systemSig, maskId);
            }

            _solarSystemService.UpdateSystem(system);

            return GetSolarSystemById(mainToken, dto.Id);
        }

        [HttpGet("Find")]
        public List<SolarSystemDto> Find([FromQuery]string name)
        {
            return _solarSystemService.Find(name, 5).Select(x => new SolarSystemDto
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}
