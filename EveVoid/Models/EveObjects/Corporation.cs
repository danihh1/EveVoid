using EveVoid.Models.Pilots;
using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.EveObjects
{
    public class Corporation: IHasUpdateTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? AllianceId { get; set; }
        public DateTime LastUpdate { get; set; }
        public virtual Alliance Alliance { get; set; }
        public virtual List<MainCharacter> Mains { get; set; }
        public virtual List<EsiCharacter> EsiCharacters { get; set; }

        public Corporation()
        {
            Mains = new List<MainCharacter>();
            EsiCharacters = new List<EsiCharacter>();
        }
    }
}
