using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.Navigation.MapObjects
{
    public class Region : IHasUpdateTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }
        public virtual List<Constellation> Constellations { get; set; }
        public Region()
        {
            Constellations = new List<Constellation>();
        }
    }
}
