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

namespace EveVoid.Data
{
    public class DbInitializer
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public static void Initialize(EveVoidContext context)
        {
            var universeApi = new UniverseApi();
            context.Database.EnsureCreated();

            //if (context.SystemTypes.Any())
            //{
            //    return;
            //}

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
                context.SystemTypes.AddRange(systemTypes.Select(s => new SystemType { Name = s }));
                context.SystemTypes.Add(new SystemType { Name = "Unknown" });
                context.SaveChanges();
            }
            if (!context.WormholeTypes.Any())
            {
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
            if (!context.Constellaions.Any())
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
                context.Constellaions.AddRange(addList);
                context.SaveChanges();
            }
            if (!context.SolarSystems.Any())
            {
                context.SolarSystems.AddRange(json.systems.Select(x => new SolarSystem
                {
                    Id = int.Parse(x.Key),
                    Name = x.Value.name,
                    Class = x.Value.wClass == null ? 0 : int.Parse(x.Value.wClass),
                    Statics = x.Value.statics == null ? null : x.Value.statics.Select(s => new WormholeStatic
                    {
                        SystemId = int.Parse(x.Key),
                        WormholeTypeId = context.WormholeTypes.FirstOrDefault(e => e.Name == s).Id
                    }).ToList(),
                    SystemTypeId = context.SystemTypes.FirstOrDefault(e => e.Name == getSystemTypeForCombine(x.Value)).Id,
                    ConstellaionId = int.Parse(x.Value.constellationID)
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
    }
}