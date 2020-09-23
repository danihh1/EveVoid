using EveVoid.Models.Navigation.Masks;
using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;

namespace EveVoid.Models.Navigation.MapObjects
{
    public class Dscan : IHasCreationTime
    {
        public int Id { get; set; }
        public int SolarSystemId { get; set; }
        public int MaskId { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual SolarSystem SolarSystem { get; set; }
        public virtual Mask Mask { get; set; }
        public virtual List<DscanShip> DscanShips { get; set; }

        public Dscan()
        {
            DscanShips = new List<DscanShip>();
        }
    }
}
