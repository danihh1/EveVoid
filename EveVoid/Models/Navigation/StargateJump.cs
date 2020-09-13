using EveVoid.Models.EveObjects;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Models.Pilots;
using EveVoid.Models.Shared;
using System;

namespace EveVoid.Models.Navigation
{
    public class StargateJump: IMasked, IHasCreationTime
    {
        public int Id { get; set; }
        public int ShipId { get; set; }
        public int StargateId { get; set; }
        public int EsiCharacterId { get; set; }
        public DateTime CreationDate { get; set; }
        public int MaskId { get; set; }

        public virtual Stargate Stargate { get; set; }
        public virtual EsiCharacter EsiCharacter { get; set; }
        public virtual ItemType Ship { get; set; }
        public virtual Mask Mask { get; set; }
    }
}