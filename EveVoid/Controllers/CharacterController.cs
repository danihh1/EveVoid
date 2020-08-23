using EveVoid.Dto;
using EveVoid.Models.Pilots;
using EveVoid.Services;
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
        private readonly ITokenService _tokenService;

        public CharacterController(ICharacterService characterService, 
            ITokenService tokenService)
        {
            _characterService = characterService;
            _tokenService = tokenService;
        }
        [HttpGet("GetMainCharacter")]
        public ActionResult<MainCharacterDto> GetMainCharacter(string token)
        {
            return Ok(Map(_characterService.GetMainCharacterByToken(token)));
        }

        [HttpPost("GetEsiCharacter")]
        public ActionResult<EsiCharacterDto> GetEsiCharacter(string mainToken, string esiToken)
        {
            return Ok(Map(_characterService.GetEsiCharacterWithActiveToken(mainToken, esiToken)));
        }

        [HttpPost("UpdateEsiCharacter")]
        public ActionResult<EsiCharacterDto> UpdateEsiCharacter(string mainToken, EsiCharacterDto dto)
        {
            return Ok(Map(_characterService.UpdateEsiCharacter(mainToken, dto)));
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
                EsiCharacterDtos = mainCharacter.EsiCharacters.Select(x => Map(x)).ToList()
            };
            return dto;
        }

        private EsiCharacterDto Map(EsiCharacter esiCharacter)
        {
            var dto = new EsiCharacterDto
            {
                Id = esiCharacter.Id,
                Name = esiCharacter.Name,
                CorporationId = esiCharacter.CorporationId,
                CorporationName = esiCharacter.Corporation.Name,
                AllianceId = esiCharacter.Corporation.AllianceId,
                AllianceName = esiCharacter.Corporation.Alliance?.Name,
                CurrentSystemId = esiCharacter.CurrentSystemId,
                CurrentSystemName = esiCharacter.CurrentSystem?.Name,
                CurrentShipTypeId = esiCharacter.CurrentShipTypeId,
                CurrentShipTypeName = esiCharacter.CurrentShip?.Name,
                CurrentShipName = esiCharacter.CurrentShipName,
                EsiToken = esiCharacter.AccessToken
            };
            return dto;
        }
    }
}
