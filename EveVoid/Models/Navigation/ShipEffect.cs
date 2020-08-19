using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.Navigation
{
    public class ShipEffect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public bool IsNegative { get; set; }
    }
}
