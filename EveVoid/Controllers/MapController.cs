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
            var maskId = main.MaskType == MaskType.Alliance && main.Corporation.AllianceId != null ? main.Corporation.Alliance.MaskId : main.Corporation.MaskId;
            var system = _solarSystemService.GetSystemById(systemId);

            var res = Map(system, customName, maskId, maxGateLevel);
            return res;
        }

        private void RecurseMap(SolarSystem system, string customName, int maskId, MapDto map, int level, int maxGateLevel)
        {
            map.Nodes.Add(new MapNodeDto
            {
                Id = system.Id.ToString(),
                Color = "#121212",
                Name = customName.IsNullOrEmpty() ? system.Name : customName,
                SystemType = system.SystemType?.Name,
                Statics = system.Statics.Select(x => new WormholeTypeMapDto {
                    Name = x.WormholeType.Name,
                    Duration = x.WormholeType.Duration,
                    MaxJump = x.WormholeType.MaxJump,
                    MaxMass = x.WormholeType.MaxMass,
                    LeadsTo = x.WormholeType.LeadsTo.Name,
                    Color = SystemTypeColor(x.WormholeType.LeadsTo.Name)
                }).ToList(),
                SystemTypeColor = SystemTypeColor(system.SystemType?.Name),
                Pilots = system.Pilots.Select(x => new ActivePilotDto
                {
                    Name = x.Name,
                    ShipName = x.CurrentShipName,
                    ShipTypeName = x.CurrentShip?.Name
                }).ToList()
            });
            if (system.Gates.Any())
            {
                level++;
            }
            foreach (var connection in system.GetConnections(maskId, includeGates: level <= maxGateLevel))
            {
                if (!map.EdgeExists(system.Id.ToString(), connection.SolarSystem.Id.ToString()))
                {
                    var gate = system.Gates.FirstOrDefault(x => x.Destination.SystemId == connection.SolarSystem.Id);
                    if (gate != null)
                    {
                        map.Edges.Add(new MapEdgeDto
                        {
                            Id = 'g'+gate.Id.ToString(),
                            SourceName = "Gate",
                            TargetName = "Gate",
                            Color = "lightblue",
                            Source = system.Id.ToString(),
                            Target = connection.SolarSystem.Id.ToString(),
                            LineWidth = "4",
                            LineType = ""
                        });
                    }
                    else
                    {
                        var signature = connection.Signature;
                        if (signature != null)
                        {
                            map.Edges.Add(new MapEdgeDto
                            {
                                Id = signature.Id.ToString(),
                                SourceName = signature.Destination == null ? "???" : signature.Destination.SignatureId,
                                TargetName = signature.SignatureId,
                                TargetId = signature.DestinationId?.ToString(),
                                LineWidth = WormholeWidthBasedOnMaxJump(signature.WormholeType?.MaxJump),
                                Color = WormholeColorBasedOnRemainingMass(signature),
                                Source = system.Id.ToString(),
                                Target = connection.SolarSystem.Id.ToString(),
                                LineType = signature.ExpiryDate >= DateTime.UtcNow.AddHours(4) ? "" : "10"
                            });
                        }
                    }
                }
                if (!map.NodeExists(connection.SolarSystem.Id.ToString()))
                {
                    RecurseMap(connection.SolarSystem, connection.Signature.Name, maskId, map, level, maxGateLevel);
                }
            }
        }

        private MapDto Map(SolarSystem system, string customName, int maskId, int maxGateLevel)
        {
            var res = new MapDto
            {
                RootNodeId = system.Id
            };
            RecurseMap(system, customName, maskId, res, 0, maxGateLevel);
            return res;
        }

        private string SystemTypeColor(string systemType)
        {
            var res = "";
            switch (systemType)
            {

                case "Class 3":
                case "Unknown":
                case "Class 1":
                case "Class 2":
                case "Class 15":
                case "Class 17":
                case "Class 18":
                case "Class 14":
                case "Class 16":
                case "Class 13":
                default:
                    {
                        res = "#1f88ff";
                        break;
                    }
                case "High-Sec":
                    {
                        res = "#1fff1f";
                        break;
                    }
                case "Low-Sec":
                    {
                        res = "#ffc71f";
                        break;
                    }
                case "Thera":
                    {
                        res = "#fffb1f";
                        break;
                    }
                case "Class 5":
                    {
                        res = "#ff7d1f";
                        break;
                    }
                case "Class 6":
                    {
                        res = "#ff1f4c";
                        break;
                    }
                case "Class 4":
                    {
                        res = "#b81fff";
                        break;
                    }
                case "Null-Sec":
                    {
                        res = "#ff1f1f";
                        break;
                    }
            };
            return res;
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
