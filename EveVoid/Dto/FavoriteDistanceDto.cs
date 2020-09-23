using System.Collections.Generic;

namespace EveVoid.Dto
{
    public class FavoriteDistanceDto
    {
        public int SystemId { get; set; }
        public string SystemName { get; set; }
        public int DistanceInJumps { get; set; }

        public List<RouteDto> Route { get; set; }

        public FavoriteDistanceDto()
        {
            Route = new List<RouteDto>();
        }
    }

    public class RouteDto
    {
        public int SystemId { get; set; }
        public string SystemName { get; set; }
        public int Order { get; set; }
        public string Color { get; set; }
    }
}
