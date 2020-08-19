using EveVoid.Models.Navigation.MapObjects;

namespace EveVoid.Models.Navigation
{
    public class WormholeStatic
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public int WormholeTypeId { get; set; }
        public virtual WormholeType WormholeType { get; set; }
        public virtual SolarSystem SolarSystem { get; set; }
    }
}