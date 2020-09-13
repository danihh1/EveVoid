using EveVoid.Models.EveObjects;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Models.Shared;
using System;

namespace EveVoid.Models.Navigation.MapObjects
{
    public class SolarSystemStructure : IHasCreationTime, IHasUpdateTime
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public int ItemTypeId { get; set; }
        public int MaskId { get; set; }
        public int SolarSystemId { get; set; }

        public virtual Mask Mask { get; set; }
        public virtual ItemType ItemType { get; set; }
        public virtual SolarSystem SolarSystem { get; set; }
    }
}
