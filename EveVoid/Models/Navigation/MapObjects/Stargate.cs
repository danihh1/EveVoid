using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveVoid.Models.Navigation.MapObjects
{
    public class Stargate: IHasUpdateTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int SystemId { get; set; }
        public int? DestinationId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SolarSystem SolarSystem { get; set; }
        public virtual Stargate Destination { get; set; }
        public virtual List<StargateJump> StargateJumps { get; set; }

        public Stargate()
        {
            StargateJumps = new List<StargateJump>();
        }
    }
}