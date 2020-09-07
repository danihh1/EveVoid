using EveVoid.Models.Navigation.MapObjects;

namespace EveVoid.Models.Pilots
{
    public class MapLayout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public int MainCharacterId { get; set; }
        public int SolarSystemId { get; set; }

        public virtual SolarSystem SolarSystem { get; set; }
        public virtual MainCharacter MainCharacter { get; set; }
    }
}
