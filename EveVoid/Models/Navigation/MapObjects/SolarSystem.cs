using EveVoid.Models.Pilots;
using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.Navigation.MapObjects
{
    public class SolarSystem : IHasUpdateTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public double Security { get; set; }
        public int SystemTypeId { get; set; }
        public int ConstellationId { get; set; }
        public DateTime LastUpdate { get; set; }
        public string SystemEffect { get; set; }
        public virtual SystemType SystemType { get; set; }
        public virtual List<WormholeStatic> Statics { get; set; }
        public virtual List<Signature> Signatures { get; set; }
        public virtual List<EsiCharacter> Pilots { get; set; }
        public virtual List<Stargate> Gates { get; set; }
        public virtual Constellation Constellation { get; set; }
        public virtual List<SolarSystemNote> Notes { get; set; }
        public virtual List<SolarSystemTag> Tags { get; set; }
        public virtual List<SolarSystemStructure> Structures { get; set; }
        public virtual List<Dscan> Dscans { get; set; }

        public SolarSystem()
        {
            Signatures = new List<Signature>();
            Statics = new List<WormholeStatic>();
            Pilots = new List<EsiCharacter>();
            Gates = new List<Stargate>();
            Notes = new List<SolarSystemNote>();
            Tags = new List<SolarSystemTag>();
            Structures = new List<SolarSystemStructure>();
            Dscans = new List<Dscan>();
        }
    }
}
