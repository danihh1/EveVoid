using EveVoid.Models.EveObjects;
using EveVoid.Models.Navigation;
using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using EveVoid.Models.Navigation.Masks;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EveVoid.Models.Pilots
{
    public class MainCharacter: IEsiEntity, IHasUpdateTime
    {
        public int Id { get; set; }
        public int PilotId { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime LastUpdate { get; set; }
        public MaskType MaskType { get; set; }

        public virtual List<FavoriteSystem> FavoriteSystems { get; set; }
        public virtual List<EsiCharacter> EsiCharacters { get; set; }
        public virtual List<MapLayout> MapLayouts { get; set; }
        public virtual Pilot Pilot { get; set; }

        public MainCharacter()
        {
            EsiCharacters = new List<EsiCharacter>();
        }
    }
}
