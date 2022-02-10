using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Castle.Core.Internal;
using EveVoid.Dto;
using EveVoid.Extensions;
using EveVoid.Models.Navigation;
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
        private readonly IMapper _mapper;

        public MapController(ISolarSystemService solarSystemService,
            ICharacterService characterService, 
            IMapper mapper)
        {
            _solarSystemService = solarSystemService;
            _characterService = characterService;
            _mapper = mapper;
        }

        [HttpGet("GetMapForRootId")]
        public MapDto GetMapForRootId(string mainToken, int systemId, string customName, int maxGateLevel)
        {
            var main = _characterService.GetMainCharacterByToken(mainToken);
            var maskId = main.MaskType == MaskType.Alliance && main.Pilot.Corporation.AllianceId != null ? main.Pilot.Corporation.Alliance.MaskId : main.Pilot.Corporation.MaskId;
            var system = _solarSystemService.GetSystemById(systemId);

            var res = Map(system, customName, maskId, maxGateLevel);
            return res;
        }

        //private void RecurseMap(SolarSystem system, string customName, int maskId, MapDto map, int level, int gateLevel, int maxGateLevel)
        //{
        //    map.Nodes.Add(new MapNodeDto
        //    {
        //        Id = system.Id.ToString(),
        //        Color = "#121212",
        //        Name = customName.IsNullOrEmpty() ? system.Name : customName,
        //        SystemType = system.SystemType?.Name,
        //        HasStructureData = system.Structures.Any(x => x.MaskId == maskId),
        //        WormholeEffect = system.SystemEffect,
        //        Tags = system.Tags.Where(x => x.MaskId == maskId).Select(x => _mapper.Map<SolarSystemTagDto>(x)).ToList(),
        //        Statics = system.Statics.Select(x => new WormholeTypeMapDto {
        //            Name = x.WormholeType.Name,
        //            Duration = x.WormholeType.Duration,
        //            MaxJump = x.WormholeType.MaxJump,
        //            MaxMass = x.WormholeType.MaxMass,
        //            LeadsTo = x.WormholeType.LeadsTo.Name,
        //            Color = x.WormholeType.LeadsTo.Color
        //        }).ToList(),
        //        SystemTypeColor = system.SystemType?.Color,
        //        Pilots = system.Pilots.Select(x => new ActivePilotDto
        //        {
        //            Name = x.Name,
        //            ShipName = x.CurrentShipName,
        //            ShipTypeName = x.CurrentShip?.Name
        //        }).ToList(),
        //        Rank = level
        //    });
        //    level++;
        //    if (system.Gates.Any())
        //    {
        //        gateLevel++;
        //    }
        //    foreach (var connection in system.GetConnections(maskId, includeGates: gateLevel <= maxGateLevel))
        //    {
        //        if (!map.EdgeExists(system.Id.ToString(), connection.SolarSystem.Id.ToString()))
        //        {
        //            var gate = system.Gates.FirstOrDefault(x => x.Destination.SystemId == connection.SolarSystem.Id);
        //            if (gate != null)
        //            {
        //                map.Edges.Add(new MapEdgeDto
        //                {
        //                    Id = 'g'+gate.Id.ToString(),
        //                    SourceName = "Gate",
        //                    TargetName = "Gate",
        //                    Color = "lightblue",
        //                    Source = system.Id.ToString(),
        //                    Target = connection.SolarSystem.Id.ToString(),
        //                    LineWidth = "4",
        //                    LineType = ""
        //                });
        //            }
        //            else
        //            {
        //                var signature = connection.Signature;
        //                if (signature != null)
        //                {
        //                    map.Edges.Add(new MapEdgeDto
        //                    {
        //                        Id = signature.Id.ToString(),
        //                        SourceName = signature.Destination == null ? "???" : signature.Destination.SignatureId,
        //                        TargetName = signature.SignatureId,
        //                        TargetType = signature.WormholeType.Name,
        //                        TargetId = signature.DestinationId?.ToString(),
        //                        LineWidth = WormholeWidthBasedOnMaxJump(signature.WormholeType?.MaxJump),
        //                        Color = WormholeColorBasedOnRemainingMass(signature),
        //                        Source = system.Id.ToString(),
        //                        Target = connection.SolarSystem.Id.ToString(),
        //                        LineType = signature.ExpiryDate >= DateTime.UtcNow.AddHours(4) ? "" : "10"
        //                    });
        //                }
        //            }
        //        }
        //        if (!map.NodeExists(connection.SolarSystem.Id.ToString()))
        //        {
        //            RecurseMap(connection.SolarSystem, connection.Signature.Name, maskId, map, level, gateLevel, maxGateLevel);
        //        }
        //    }
        //}

        private MapDto Map(SolarSystem system, string customName, int maskId, int maxGateLevel)
        {
            var res = new MapDto
            {
                RootNodeId = system.Id
            };
            var queue = new Stack<BFSNode>();
            queue.Push(new BFSNode
            {
                SolarSystem = system,
                Rank = 0,
                Name = customName
            });
            while (queue.Any())
            {
                var pop = queue.Pop();

                BFSMap(pop.SolarSystem, pop.Name, maskId, res, pop.Rank, queue);
            }
            //RecurseMap(system, customName, maskId, res, 0, 0, maxGateLevel);
            return res;
        }

        private class BFSNode
        {
            public SolarSystem SolarSystem { get; set; }
            public int Rank { get; set; }
            public string Name { get; set; }
        }

        private void BFSMap(SolarSystem system, string customName, int maskId, MapDto map, int level, Stack<BFSNode> queue)
        {
            if (map.NodeExists(system.Id.ToString()))
            {
                return;
            }
            map.Nodes.Add(new MapNodeDto
            {
                Id = system.Id.ToString(),
                Color = "#121212",
                Name = customName.IsNullOrEmpty() ? system.Name : customName,
                SystemType = system.SystemType?.Name,
                HasStructureData = system.Structures.Any(x => x.MaskId == maskId),
                WormholeEffect = system.SystemEffect,
                Tags = system.Tags.Where(x => x.MaskId == maskId).Select(x => _mapper.Map<SolarSystemTagDto>(x)).ToList(),
                Statics = system.Statics.Select(x => new WormholeTypeMapDto
                {
                    Name = x.WormholeType.Name,
                    Duration = x.WormholeType.Duration,
                    MaxJump = x.WormholeType.MaxJump,
                    MaxMass = x.WormholeType.MaxMass,
                    LeadsTo = x.WormholeType.LeadsTo.Name,
                    Color = x.WormholeType.LeadsTo.Color
                }).ToList(),
                SystemTypeColor = system.SystemType?.Color,
                Pilots = system.Pilots.Select(x => new ActivePilotDto
                {
                    PilotName = x.Pilot.Name,
                    ShipName = x.CurrentShipName,
                    ShipTypeName = x.CurrentShip?.Name
                }).ToList(),
                Rank = level
            });
            foreach (var connection in system.GetConnections(maskId, includeGates: false))
            {
                if (!map.EdgeExists(system.Id.ToString(), connection.SolarSystem.Id.ToString()))
                {
                    var signature = connection.Signature;
                    if (signature != null)
                    {
                        map.Edges.Add(new MapEdgeDto
                        {
                            Id = signature.Id.ToString(),
                            SourceName = signature.Destination == null ? "???" : signature.Destination.SignatureId,
                            TargetName = signature.SignatureId,
                            TargetType = signature.WormholeType != null ? signature.WormholeType.Name : "????",
                            TargetId = signature.DestinationId?.ToString(),
                            LineWidth = WormholeWidthBasedOnMaxJump(signature.WormholeType?.MaxJump),
                            Color = WormholeColorBasedOnRemainingMass(signature),
                            Source = system.Id.ToString(),
                            Target = connection.SolarSystem.Id.ToString(),
                            LineType = signature.ExpiryDate >= DateTime.UtcNow.AddHours(4) ? "" : "4"
                        });
                    }
                }
                if (!map.NodeExists(connection.SolarSystem.Id.ToString()))
                {
                    queue.Push(new BFSNode
                    {
                        SolarSystem = connection.SolarSystem,
                        Rank = level + 1,
                        Name = connection.Signature.Name
                    });
                }
            }
        }

        private string WormholeColorBasedOnRemainingMass(Signature signature)
        {
            var dto = _mapper.Map<SignatureDto>(signature);
            var res = "#1f88ff";
            if (dto.TotalMass >= 0.9)
            {
                res = "#ff1f4c";
            }
            else if (dto.TotalMass >= 0.5)
            {
                res = "#ff7d1f";
            }
            else if (dto.TotalMass < 0)
            {
                res = "#ee20f5";
            }
            return res;
            //var maxJump = signature.WormholeType?.MaxJump;
            //if (maxJump == null)
            //{
            //    return res;
            //}
            //if (maxJump <= 5000000)
            //{
            //    res = "#ee20f5";
            //}
            //else
            //{
            //    switch (signature.MassIndicator)
            //    {
            //        case MassIndicator.Unset:
            //            {
            //                var percentagePassed = signature.Jumps.Sum(x => x.Ship.Mass) / signature.WormholeType.MaxMass;
            //                if (percentagePassed >= 0.9) 
            //                {
            //                    res = "#ff1f4c";
            //                }
            //                else if (percentagePassed >= 0.5)
            //                {
            //                    res = "#ff7d1f";
            //                }
            //                break;
            //            }
            //        case MassIndicator.Destab:
            //            {
            //                res = "#ff7d1f";
            //                break;
            //            }
            //        case MassIndicator.VoC:
            //            {
            //                res = "#ff1f4c";
            //                break;
            //            }
            //    }
            //}
            //return res;
        }

        private string WormholeWidthBasedOnMaxJump(double? maxJump)
        {
            var res = 3;
            if (maxJump == null)
            {
                res = 3;
            } else if (maxJump <= 5000000)
            {//frig
                res = 1;
            }
            else if (maxJump <= 20000000)
            {//c1
                res = 2;
            }
            else if (maxJump <= 300000000)
            {//normal
                res = 3;
            }
            else if (maxJump <= 1000000000)
            {//small capital
                res = 4;
            }
            else if (maxJump <= 1350000000)
            {//capital
                res = 5;
            }
            else
            {//large capital
                res = 6;
            }
            return res + "";
        }
    }
}
