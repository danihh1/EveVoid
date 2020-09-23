using AutoMapper;
using EveVoid.Dto;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Services.Navigation;
using EveVoid.Services.Navigation.MapObjects;
using EveVoid.Services.Pilots;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EveVoid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRouteService _routeService;
        private readonly ICharacterService _characterService;

        public RouteController(IMapper mapper,
            ITagService tagService,
            ICharacterService characterService, 
            IRouteService routeService)
        {
            _mapper = mapper;
            _characterService = characterService;
            _routeService = routeService;
        }

        [HttpGet("")]
        public List<FavoriteDistanceDto> GetRouteToFavorites(string mainToken, int originSystemId, RouteType routeType)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Corporation.AllianceId != null ? main.Corporation.Alliance.MaskId : main.Corporation.MaskId;
            var favorites = main.FavoriteSystems.Where(x=>x.SolarSystemId != originSystemId).ToList();
            var res = new List<FavoriteDistanceDto>();
            foreach (var fav in favorites)
            {
                var route = _routeService.GetRoute(maskId, originSystemId, fav.SolarSystemId, routeType);
                res.Add(route);
            }
            return res;
        }
    }
}
