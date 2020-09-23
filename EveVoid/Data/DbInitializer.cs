using EveVoid.Models.Combine;
using EveVoid.Models.Navigation;
using EveVoid.Models.Navigation.MapObjects;
using IO.Swagger.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using NLog;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using EveVoid.Dto;
using Microsoft.EntityFrameworkCore;
using EveVoid.Extensions;
using EveVoid.Models.Navigation.Matrix;

namespace EveVoid.Data
{
    public class DbInitializer
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public static void Initialize(EveVoidContext context)
        {
            var universeApi = new UniverseApi();
            context.Database.Migrate();
            //context.Database.EnsureCreated();

            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\combine.json");
            var jsonText = File.ReadAllText(path);
            var json = JsonConvert.DeserializeObject<CombineDump>(jsonText);

            if (!context.Regions.Any())
            {
                var addList = new List<Region>();
                addList.AddRange(json.regions.Select(x => new Region
                {
                    Id = int.Parse(x.Key),
                    Name = x.Value.name
                }));

                var regionIdList = universeApi.GetUniverseRegions(null, null);
                var jsonRegionIds = json.regions.Select(j => int.Parse(j.Key)).ToHashSet();
                foreach (var missingRegion in regionIdList.Where(r => !jsonRegionIds.Contains(r.GetValueOrDefault())))
                {
                    if (missingRegion == null)
                    {
                        continue;
                    }
                    var esiRegion = universeApi.GetUniverseRegionsRegionId(missingRegion.Value, "en-us", null, null, "en-us");
                    addList.Add(new Region
                    {
                        Id = esiRegion.RegionId.Value,
                        Name = esiRegion.Name,
                    });
                }
                context.Regions.AddRange(addList);
                context.SaveChanges();
            }

            var systemTypes = json.wormholes.Select(x => x.Value.leadsTo).Distinct().ToList();
            if (!context.SystemTypes.Any())
            {
                context.SystemTypes.AddRange(systemTypes.Select(s => new SystemType { Name = s, Color = SystemTypeColor(s) }));
                context.SystemTypes.Add(new SystemType { Name = "Unknown", Color = SystemTypeColor("Unknown") });
                context.SaveChanges();
            }
            if (!context.WormholeTypes.Any())
            {
                context.WormholeTypes.Add(new WormholeType
                {
                    Name = "????",
                    LeadsTo = context.SystemTypes.FirstOrDefault(s => s.Name == "Unknown"),
                    MaxMass = 2000000000,
                    MaxJump = 300000000,
                    Duration = "24 Hours"
                });
                context.WormholeTypes.Add(new WormholeType
                {
                    Name = "K162",
                    LeadsTo = context.SystemTypes.FirstOrDefault(s => s.Name == "Unknown"),
                    MaxMass = 2000000000,
                    MaxJump = 300000000,
                    Duration = "24 Hours"
                });
                context.WormholeTypes.AddRange(json.wormholes.Select(x => new WormholeType
                {
                    Name = x.Key,
                    LeadsTo = context.SystemTypes.FirstOrDefault(s => s.Name == x.Value.leadsTo),
                    MaxMass = x.Value.mass,
                    MaxJump = x.Value.jump,
                    Duration = x.Value.life
                }));
                context.SaveChanges();
            }
            if (!context.Constellations.Any())
            {
                var addList = new List<Constellation>();
                var constellationIdList = universeApi.GetUniverseConstellations(null, null);
                foreach (var constellationId in constellationIdList)
                {
                    if (constellationId == null)
                    {
                        continue;
                    }
                    addList.Add(new Constellation
                    {
                        Id = constellationId.Value,
                        Name = "Temp",
                        RegionId = context.Regions.First().Id,
                        LastUpdate = DateTime.Now.AddDays(-2)
                    });
                }
                context.Constellations.AddRange(addList);
                context.SaveChanges();
            }
            if (!context.SolarSystems.Any())
            {
                context.SolarSystems.AddRange(json.systems.Select(x => new SolarSystem
                {
                    Id = int.Parse(x.Key),
                    Name = x.Value.name,
                    Security = x.Value.security == null ? 0 : double.Parse(x.Value.security),
                    Class = x.Value.wClass == null ? 0 : int.Parse(x.Value.wClass),
                    SystemEffect = x.Value.effect,
                    Statics = x.Value.statics?.Select(s => new WormholeStatic
                    {
                        SystemId = int.Parse(x.Key),
                        WormholeTypeId = context.WormholeTypes.FirstOrDefault(e => e.Name == s).Id
                    }).ToList(),
                    SystemTypeId = context.SystemTypes.FirstOrDefault(e => e.Name == getSystemTypeForCombine(x.Value)).Id,
                    ConstellationId = int.Parse(x.Value.constellationID)
                }));
                context.SaveChanges();
            }
            if (!context.Stargates.Any())
            {
                context.Stargates.AddRange(json.stargates.Select(x => new Stargate
                {
                    Id = int.Parse(x.Key),
                    SystemId = x.Value.systemId
                }));
                context.SaveChanges();
                var stargates = context.Stargates.ToDictionary(x => x.Id, x => x);
                foreach (var stargate in json.stargates)
                {
                    stargates[int.Parse(stargate.Key)].DestinationId = stargate.Value.destinationId;
                }
                context.SaveChanges();
            }
            if (!context.AdjacencyMatrix.Any())
            {
                var systems = context.SolarSystems.ToList();
                var matrix = new Dictionary<int, Dictionary<int, int>>();
                foreach (var system in systems)
                {
                    var maskId = -1;
                    var adjs = system.GetConnections(maskId, true).Select(x => x.SolarSystem);
                    foreach (var adj in adjs)
                    {
                        context.AdjacencyMatrix.Add(new AdjacencyMatrix
                        {
                            RowNumber = system.Id,
                            ColumnNumber = adj.Id,
                            Distance = system.Security < 0.5 || adj.Security < 0.5 ? 100 : 1,
                            MaskId = maskId
                        });
                    }
                }
                context.SaveChanges();
            }
            //var _universeApi = new UniverseApi();
            //var index = 1;
            //foreach (var systemId in json.systems.Keys)
            //{
            //    var didTimeout = true;
            //    while (didTimeout)
            //    {
            //        try { 
            //            _logger.Info(index++ + "/" + json.systems.Count);
            //            var esiResult = _universeApi.GetUniverseSystemsSystemId(int.Parse(systemId), "en-us", null, null, "en-us");
            //            if (esiResult.Stargates != null)
            //            {
            //                foreach (var gateId in esiResult.Stargates)
            //                {
            //                    if (gateId.HasValue)
            //                    {
            //                        var gate = context.Stargates.FirstOrDefault(x => x.Id == gateId);
            //                        if (gate == null)
            //                        {
            //                            var esiResult2 = _universeApi.GetUniverseStargatesStargateId(gateId, null, null);
            //                            var desto = new Stargate
            //                            {
            //                                Id = esiResult2.Destination.StargateId.Value,
            //                                SystemId = esiResult2.Destination.SystemId.Value,

            //                            };
            //                            context.Stargates.Add(desto);
            //                            gate = new Stargate
            //                            {
            //                                Id = gateId.Value,
            //                                SystemId = esiResult2.SystemId.Value,
            //                            };
            //                            context.Stargates.Add(gate);
            //                            context.SaveChanges();
            //                            desto.DestinationId = gate.Id;
            //                            gate.DestinationId = desto.Id;
            //                            context.SaveChanges();
            //                        }
            //                    }
            //                }
            //            }
            //            didTimeout = false;
            //        }
            //        catch(Exception e)
            //        {
            //            if (!e.Message.Contains("timeout"))
            //            {
            //                didTimeout = false;
            //            }
            //        }
            //    }
            //}
        }

        public static string getSystemTypeForCombine(CombineSystem system)
        {
            
            if (system.wClass != null)
            {// w space
                if (system.wClass == "12")
                {
                    return "Thera";
                }
                return "Class " + system.wClass;
            }
            else
            {
                var secStatus = double.Parse(system.security);
                if (secStatus >= 0.5)
                {
                    return "High-Sec";
                }
                if (secStatus > 0)
                {
                    return "Low-Sec";
                }
                return "Null-Sec";
            }
        }

        private static string SystemTypeColor(string systemType)
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
    }
}