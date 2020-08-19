using EveVoid.Models.EveObjects;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Pilots;
using System;

namespace EveVoid.Models.Navigation
{
    public class StargateJump
    {
        public int Id { get; set; }
        public int ShipId { get; set; }
        public int StargateId { get; set; }
        public int EsiCharacterId { get; set; }
        public DateTime JumpDate { get; set; }

        public virtual Stargate Stargate { get; set; }
        public virtual EsiCharacter EsiCharacter { get; set; }
        public virtual Ship Ship { get; set; }
    }
}