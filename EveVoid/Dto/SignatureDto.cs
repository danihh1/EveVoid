using EveVoid.Models.Navigation;
using System;
using System.Collections.Generic;

namespace EveVoid.Dto
{
    public class SignatureDto
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SignatureId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public SignatureType SignatureType { get; set; }

        //wormhole
        public int? WormholeTypeId { get; set; }
        public MassIndicator MassIndicator { get; set; }
        public TimeRemainingIndicator TimeRemainingIndicator { get; set; }
        public int? DestinationSystemId { get; set; }
        public string DestinationSystemName { get; set; }
        public string DestinationWormholeType { get; set; }
        public double TotalMass { get; set; }
        public string WormholeType { get; set; }

        public List<JumpDto> Jumps { get; set; }

        public SignatureDto()
        {
            MassIndicator = MassIndicator.Unset;
            TimeRemainingIndicator = TimeRemainingIndicator.Unset;
            Jumps = new List<JumpDto>();
        }
    }
}
