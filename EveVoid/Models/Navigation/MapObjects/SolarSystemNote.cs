using EveVoid.Models.Navigation.Masks;
using EveVoid.Models.Pilots;
using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.Navigation.MapObjects
{
    public class SolarSystemNote : IMasked, IHasUpdateTime, IHasCreationTime
    {
        public int Id { get; set; }
        public int MainCharacterId { get; set; }
        public int SolarSystemId { get; set; }
        public int MaskId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual MainCharacter MainCharacter { get; set; }
        public virtual SolarSystem SolarSystem { get; set; }
        public virtual Mask Mask { get; set; }
    }
}
