using EveVoid.Models.EveObjects;
using EveVoid.Models.Navigation;
using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using EveVoid.Models.Navigation.Masks;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.Pilots
{
    public class MainCharacter: IEsiEntity, IHasUpdateTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CorporationId { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime LastUpdate { get; set; }
        public MaskType MaskType { get; set; }

        public virtual List<EsiCharacter> EsiCharacters { get; set; }
        public virtual Corporation Corporation { get; set; }

        public MainCharacter()
        {
            EsiCharacters = new List<EsiCharacter>();
        }
    }
}
