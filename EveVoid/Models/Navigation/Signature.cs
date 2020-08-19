using EveVoid.Models.Navigation.MapObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.Navigation
{
    public class Signature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SignatureId { get; set; }
        public int SystemId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public SignatureType SignatureType { get; set; }
        public int? LeadsToId { get; set; }
        public int TypeId { get; set; }
        public double TotalMass
        {
            get
            {
                return Jumps.Sum(x => x.Ship.Mass);
            }
        }
        public virtual SolarSystem System { get; set; }
        public virtual Signature LeadsTo { get; set; }
        public virtual WormholeType WormholeType { get; set; }
        public virtual List<Jump> Jumps { get; set; }

        public Signature()
        {
            Jumps = new List<Jump>();
        }
    }
}
