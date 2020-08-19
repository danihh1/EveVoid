using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveVoid.Models.Navigation.MapObjects
{
    public class Constellation : IHasUpdateTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
        public virtual Region Region { get;set; }
        public virtual List<SolarSystem> SolarSystems { get; set; }
        public DateTime LastUpdate { get; set; }

        public Constellation()
        {
            SolarSystems = new List<SolarSystem>();
        }


    }
}