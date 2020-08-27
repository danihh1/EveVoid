using EveVoid.Models.Navigation.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Extensions
{
    public static class SolarSystemExtension
    {
        public static List<SolarSystem> GetNeighbors(this SolarSystem system, bool includeGates = false)
        {
            var wormholeConnections = system.Signatures.Where(x => x.LeadsToId != null).Select(x => x.LeadsTo.System);
            if (includeGates)
            {
                wormholeConnections = wormholeConnections.Union(system.Gates.Where(x => x.DestinationId != null).Select(x => x.Destination.SolarSystem));
            }
            return wormholeConnections.ToList();
        }
    }
}
