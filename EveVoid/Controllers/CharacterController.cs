using AutoMapper;
using EveVoid.Dto;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Models.Pilots;
using EveVoid.Services;
using EveVoid.Services.Pilots;
using Microsoft.AspNetCore.Mvc;
using NLog;
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
        private readonly IMapper _mapper;
        private readonly ICharacterService _characterService;
        private readonly ITokenService _tokenService;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public CharacterController(ICharacterService characterService,
            ITokenService tokenService, 
            IMapper mapper)
        {
            _characterService = characterService;
            _tokenService = tokenService;
            _mapper = mapper;
        }
        [HttpGet("GetMainCharacter")]
        public ActionResult<MainCharacterDto> GetMainCharacter(string token)
        {
            var main = _characterService.GetMainCharacterByToken(token);
            if (main == null)
            {
                return NotFound();
            }
            var res = _mapper.Map<MainCharacterDto>(main);
            return Ok(res);
        }

        [HttpPost("GetEsiCharacter")]
        public ActionResult<EsiCharacterDto> GetEsiCharacter(string mainToken, int esiCharId)
        {
            var res = _characterService.GetEsiCharacterWithActiveToken(mainToken, esiCharId);
            if (res == null)
            {
                return NotFound(res);
            }
            return Ok(_mapper.Map<EsiCharacterDto>(res));
        }

        [HttpPost("UpdateEsiCharacter")]
        public ActionResult<EsiCharacterDto> UpdateEsiCharacter(string mainToken, EsiCharacterDto dto, int sigId)
        {
            var res = _characterService.UpdateEsiCharacter(mainToken, dto, sigId);
            if (res == null)
            {
                return NotFound(res);
            }
            return Ok(_mapper.Map<EsiCharacterDto>(res));
        }

        [HttpPost("UpdateMaskType")]
        public ActionResult UpdateMaskType(string mainToken, MaskType maskType)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            if (main == null)
            {
                return NotFound();
            }
            main.MaskType = maskType;
            _characterService.UpdateMainCharacter(main);
            return Ok();
        }

        [HttpPost("UpdateFavoriteSystem")]
        public ActionResult UpdateFavoriteSystem(string mainToken, int systemId, bool favorite)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            if (main == null)
            {
                return NotFound();
            }
            main.FavoriteSystems.RemoveAll(x => x.SolarSystemId == systemId);
            if (favorite)
            {
                main.FavoriteSystems.Add(new FavoriteSystem
                {
                    SolarSystemId = systemId
                });
            }
            _characterService.UpdateMainCharacter(main);
            return Ok();
        }

        [HttpPost("UpdateMapLayouts")]
        public ActionResult<List<MapLayoutDto>> UpdateMapLayouts(string mainToken, List<MapLayoutDto> dtos)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            if (main == null)
            {
                return NotFound();
            }
            var dtoIdHash = dtos.Select(x => x.Id).ToHashSet();
            main.MapLayouts.RemoveAll(x => !dtoIdHash.Contains(x.Id));
            foreach (var mapDto in dtos)
            {
                var map = main.MapLayouts.FirstOrDefault(x => x.Id == mapDto.Id);
                if (map == null)
                {
                    map = new MapLayout
                    {
                        Name = mapDto.Name,
                        SolarSystemId = mapDto.SolarSystemId
                    };
                    main.MapLayouts.Add(map);
                }
                else
                {
                    map.Name = mapDto.Name;
                    map.SolarSystemId = mapDto.SolarSystemId;
                }
            }
            _characterService.UpdateMainCharacter(main);
            return Ok(_mapper.Map<List<MapLayoutDto>>(main.MapLayouts));
        }
    }
}
