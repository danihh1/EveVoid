using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.Combine
{
    public class CombineDump
    {
        public Dictionary<string,CombineSystem> systems { get; set; }
        public Dictionary<string, CombineName> regions { get; set; }
        public Dictionary<string, CombineName> factions { get; set; }
        public Dictionary<string, CombineWormhole> wormholes { get; set; }
        public Dictionary<string, List<CombineWormholeEffect>> effects { get; set; }
    }

    public class CombineSystem
    {
        public string name { get; set; }
        public string security { get; set; }
        public string constellationID { get; set; }
        public string regionID { get; set; }
        public string factionID { get; set; }
        [JsonProperty("class")]
        public string wClass { get; set; }
        public string effect { get; set; }
        public string[] statics { get; set; }
    }

    public class CombineWormhole
    {
        public string life { get; set; }
        public string leadsTo { get; set; }
        public long mass { get; set; }
        public long jump { get; set; }
    }
    public class CombineWormholeEffect
    {
        public string name { get; set; }
        [JsonProperty(PropertyName = "base")]
        public double baseValue { get; set; }
        public int bad { get; set; }
    }
    public class CombineName
    {
        public string name { get; set; }
    }
}
