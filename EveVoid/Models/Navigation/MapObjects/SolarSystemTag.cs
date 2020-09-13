using EveVoid.Models.Navigation.Masks;
using EveVoid.Models.Shared;
using System;

namespace EveVoid.Models.Navigation.MapObjects
{
    public class SolarSystemTag: IHasCreationTime, IHasUpdateTime, IHasExpiry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
        public int MaskId { get; set; }
        public int SolarSystemId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public virtual Mask Mask { get; set; }
        public virtual SolarSystem SolarSystem { get; set; }
    }
}
