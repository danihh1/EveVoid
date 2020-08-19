using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.Navigation
{
    public class WormholeEffect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<ShipEffect> ShipEffects { get; set; }
        public WormholeEffect()
        {
            ShipEffects = new List<ShipEffect>();
        }
    }
}
