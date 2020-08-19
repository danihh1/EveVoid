using EveVoid.Dto;
using EveVoid.Models.Pilots;
using EveVoid.Services.Pilots;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
        [HttpGet("GetMainCharacter")]
        public MainCharacterDto GetMainCharacter(string token)
        {
            return Map(_characterService.GetMainCharacterByToken(token));
        }

        private MainCharacterDto Map(MainCharacter mainCharacter)
        {
            var dto = new MainCharacterDto
            {
                Id = mainCharacter.Id,
                Name = mainCharacter.Name,
                CorporationId = mainCharacter.CorporationId,
                CorporationName = mainCharacter.Corporation.Name,
                AllianceId = mainCharacter.Corporation.AllianceId,
                AllianceName = mainCharacter.Corporation.Alliance.Name,
                EsiCharacterDtos = mainCharacter.EsiCharacters.Select(x => new EsiCharacterDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    CorporationId = x.CorporationId,
                    CorporationName = x.Corporation.Name,
                    AllianceId = x.Corporation.AllianceId,
                    AllianceName = x.Corporation.Alliance == null ? null : x.Corporation.Alliance.Name,
                    CurrentSystemId = x.CurrentSystemId,
                    CurrentSystemName = x.CurrentSystem.Name,
                    CurrentShipId = x.CurrentShipId,
                    CurrentShipName = x.CurrentShip.Name,
                    EsiToken = x.AccessToken
                    
                }).ToList()
            };
            return dto;
        }
    }
}
