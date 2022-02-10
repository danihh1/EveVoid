using EveVoid.Models.EveObjects;
using EveVoid.Models.Navigation;
using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveVoid.Models.Pilots
{
    public class Pilot: IHasUpdateTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CorporationId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Corporation Corporation { get; set; }
        public virtual List<Jump> Jumps { get; set; }

        public Pilot()
        {
            Jumps = new List<Jump>();
        }
    }
}
