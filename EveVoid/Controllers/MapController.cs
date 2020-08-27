using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EveVoid.Dto;
using EveVoid.Extensions;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Services.Navigation.MapObjects;
using EveVoid.Services.Pilots;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EveVoid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        private readonly ISolarSystemService _solarSystemService;
        private readonly ICharacterService _characterService;

        public MapController(ISolarSystemService solarSystemService,
            ICharacterService characterService)
        {
            _solarSystemService = solarSystemService;
            _characterService = characterService;
        }

        [HttpGet("GetMapForRootId")]
        public MapDto GetMapForRootId(string mainToken, int systemId, int maxGateLevel)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Corporation.AllianceId != null ? main.Corporation.Alliance.MaskId : main.Corporation.MaskId;
            var system = _solarSystemService.GetSystemById(systemId);

            var res = Map(system, maskId, maxGateLevel);
            return res;
        }

        private void RecurseMap(SolarSystem system, int maskId, MapDto map, int level, int maxGateLevel)
        {
            level++;
            map.Nodes.Add(new MapNodeDto
            {
                Id = system.Id.ToString(),
                Color = "#121212",
                Name = system.Name,
                Pilots = system.Pilots.Select(x=> new ActivePilotDto
                {
                    Name = x.Name,
                    ShipName = x.CurrentShipName,
                    ShipTypeName = x.CurrentShip.Name
                }).ToList()
            });
            foreach (var neighbor in system.GetNeighbors(includeGates: level <= maxGateLevel))
            {
                var gateId = system.Gates.FirstOrDefault(x => x.Destination.SystemId == neighbor.Id).Id;
                if (!map.EdgeExists(system.Id.ToString(), neighbor.Id.ToString()))
                {
                    map.Edges.Add(new MapEdgeDto
                    {
                        Id = gateId.ToString(),
                        Name = "Gate",
                        Color = "lightblue",
                        Source = system.Id.ToString(),
                        Target = neighbor.Id.ToString()
                    });
                }
                if (!map.NodeExists(neighbor.Id.ToString()))
                {
                    RecurseMap(neighbor, maskId, map, level, maxGateLevel);
                }
            }
        }

        private MapDto Map(SolarSystem system, int maskId, int maxGateLevel)
        {
            var res = new MapDto
            {
                RootNodeId = system.Id
            };
            RecurseMap(system, maskId, res, 0, maxGateLevel);
            return res;
        }


    }
}
