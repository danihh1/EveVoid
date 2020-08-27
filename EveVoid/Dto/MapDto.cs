using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Dto
{
    public class MapDto
    {
        public int RootNodeId { get; set; }
        public List<MapNodeDto> Nodes { get; set; }
        public List<MapEdgeDto> Edges { get; set; }

        public MapDto()
        {
            Nodes = new List<MapNodeDto>();
            Edges = new List<MapEdgeDto>();
        }

        public bool NodeExists(string id)
        {
            return Nodes.Any(x => x.Id == id);
        }
        public bool EdgeExists(string fromId, string toId)
        {
            return Edges.Any(x => (x.Source == fromId && x.Target == toId) || (x.Target == fromId && x.Source == toId));
        }
    }

    public class MapNodeDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public List<ActivePilotDto> Pilots { get; set; }
    }

    public class MapEdgeDto
    {
        public string Id { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
