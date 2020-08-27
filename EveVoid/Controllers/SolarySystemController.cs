using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EveVoid.Dto;
using EveVoid.Models.Navigation;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Models.Pilots;
using EveVoid.Services.Navigation.MapObjects;
using EveVoid.Services.Pilots;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EveVoid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolarySystemController : ControllerBase
    {
        private readonly ISolarSystemService _solarSystemService;
        private readonly ICharacterService _characterService;

        public SolarySystemController(ISolarSystemService solarSystemService, 
            ICharacterService characterService)
        {
            _solarSystemService = solarSystemService;
            _characterService = characterService;
        }

        [HttpGet("GetSolarSystemById")]
        public SolarSystemDto GetSolarSystemById(string mainToken, int systemId)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Corporation.AllianceId != null ? main.Corporation.Alliance.MaskId : main.Corporation.MaskId;
            var system = _solarSystemService.GetSystemById(systemId);
            var res = Map(system, maskId);
            return res;
        }

        private SolarSystemDto Map(SolarSystem system, int maskId)
        {
            var res = new SolarSystemDto
            {
                Id = system.Id,
                Name = system.Name,
                Class = system.Class,
                ConstellaionId = system.ConstellaionId,
                ConstellaionName = system.Constellaion.Name,
                RegionId = system.Constellaion.RegionId,
                RegionName = system.Constellaion.Region.Name,
                SystemType = system.SystemType.Name,
                Statics = system.Statics.Select(x => x.WormholeType.LeadsTo.Name).ToList(),
                Signatures = system.Signatures.Where(s => s.MaskId == maskId).Select(x => Map(x)).ToList(),
                Pilots = system.Pilots.Where(s => s.MainCharacter.Corporation.MaskId == maskId ||
                    (s.MainCharacter.Corporation.AllianceId != null && s.MainCharacter.Corporation.Alliance.MaskId == maskId))
                    .Select(x => Map(x)).ToList(),
                Gates = system.Gates.Select(x => Map(x)).ToList(),
                Notes = system.Notes.Where(x => x.MaskId == maskId).Select(x => Map(x)).ToList()
            };
            
            return res;
        }

        private SignatureDto Map(Signature signature)
        {
            var res = new SignatureDto
            {
                Id = signature.Id,
                SignatureId = signature.SignatureId,
                CreationDate = signature.CreationDate,
                ExpiryDate = signature.ExpiryDate,
                LastUpdate = signature.LastUpdate,
                SignatureType = signature.SignatureType,
                LeadsToId = signature.LeadsToId,
                LeadsTo = signature.LeadsToId != null ? signature.LeadsTo.System.Name : null,
                WormholeTypeId = signature.WormholeTypeId,
                WormholeType = signature.WormholeTypeId != null ? Map(signature.WormholeType) : null,
                TotalMass = signature.TotalMass,
                Jumps = signature.Jumps.Select(x=> Map(x)).ToList()
            };
            return res;
        }

        private ActivePilotDto Map(EsiCharacter pilot)
        {
            var res = new ActivePilotDto
            {
                Name = pilot.Name,
                ShipName = pilot.CurrentShipName,
                ShipTypeName = pilot.CurrentShip.Name
            };
            return res;
        }

        private StargateDto Map(Stargate gate)
        {
            var res = new StargateDto
            {
                LeadsToId = gate.Destination.SolarSystem.Id,
                LeadsTo = gate.Destination.SolarSystem.Name,
                LeadsToSystemType = gate.Destination.SolarSystem.SystemType.Name
            };
            return res;
        }

        private SolarSystemNoteDto Map(SolarSystemNote note)
        {
            var res = new SolarSystemNoteDto
            {
                Id = note.Id,
                Content = note.Content,
                Title = note.Title,
                MainCharacterName = note.MainCharacter.Name,
                CreationDate = note.CreationDate,
                LastUpdate = note.LastUpdate
            };
            return res;
        }

        private WormholeTypeDto Map(WormholeType wormholeType)
        {
            var res = new WormholeTypeDto
            {
                Name = wormholeType.Name,
                Duration = wormholeType.Duration,
                LeadsTo = wormholeType.LeadsTo.Name,
                MaxJump = wormholeType.MaxJump,
                MaxMass = wormholeType.MaxMass
            };
            return res;
        }

        private JumpDto Map(Jump jump)
        {
            var res = new JumpDto
            {
                CharacterName = jump.EsiCharacter.Name,
                CreationDate = jump.CreationDate,
                Mass = jump.Ship.Mass,
                ShipType = jump.Ship.Name
            };
            return res;
        }
    }
}
