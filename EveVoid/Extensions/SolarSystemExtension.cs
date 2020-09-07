using EveVoid.Models.Navigation;
using EveVoid.Models.Navigation.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Extensions
{
    public static class SolarSystemExtension
    {
        public static List<SolarySystemConnection> GetConnections(this SolarSystem system, int maskId, bool includeGates = false)
        {
            var unknownIndex = (system.Id % 1000000) * 100;
            var wormholeConnections = system.Signatures.Where(x => x.MaskId == maskId && x.SignatureType == SignatureType.Wormhole)
                .Select(x => new SolarySystemConnection
                {
                    Signature = x,
                    SolarSystem = x.DestinationId == null ?
                 new SolarSystem
                 {
                     Id = unknownIndex++,
                     Name = "Unknown", //x.WormholeType.LeadsTo.Name,
                     SystemType = x.WormholeType?.LeadsTo
                 } :
                 x.Destination.System
                });
            if (includeGates)
            {
                wormholeConnections = wormholeConnections.Union(system.Gates.Where(x => x.DestinationId != null)
                    .Select(x => new SolarySystemConnection { SolarSystem = x.Destination.SolarSystem }));
            }
            return wormholeConnections.ToList();
        }
    }
    public class SolarySystemConnection
    {
        public SolarSystem SolarSystem { get; set; }
        public Signature Signature { get; set; }
    }
}
