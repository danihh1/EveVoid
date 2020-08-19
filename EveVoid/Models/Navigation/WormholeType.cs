using EveVoid.Models.Navigation.MapObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveVoid.Models.Navigation
{
    public class WormholeType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double MaxMass { get; set; }
        public double MaxJump { get; set; }
        public int LeadsToId { get; set; }
        public string Duration { get; set; }
        public virtual SystemType LeadsTo { get; set; }
        public virtual List<WormholeStatic> Statics { get; set; }
        public WormholeType()
        {
            Statics = new List<WormholeStatic>();
        }
    }
}
