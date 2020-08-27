using EveVoid.Models.Navigation;
using EveVoid.Models.Pilots;
using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using EveVoid.Models.Navigation.Masks;

namespace EveVoid.Models.EveObjects
{
    public class Corporation: IHasUpdateTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? AllianceId { get; set; }
        public DateTime LastUpdate { get; set; }
        public int MaskId { get; set; }

        public virtual Alliance Alliance { get; set; }
        public virtual List<MainCharacter> Mains { get; set; }
        public virtual List<EsiCharacter> EsiCharacters { get; set; }
        public virtual Mask Mask { get; set; }

        public Corporation()
        {
            Mains = new List<MainCharacter>();
            EsiCharacters = new List<EsiCharacter>();
        }
    }
}
