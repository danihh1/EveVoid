using EveVoid.Models.Navigation;
using System;
using System.Collections.Generic;

namespace EveVoid.Dto
{
    public class SignatureDto
    {
        public int Id { get; set; }
        public string SignatureId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public SignatureType SignatureType { get; set; }
        public int? LeadsToId { get; set; }
        public string LeadsTo { get; set; }
        public int? WormholeTypeId { get; set; }
        public double TotalMass { get; set; }

        public WormholeTypeDto WormholeType { get; set; }
        public List<JumpDto> Jumps { get; set; }

        public SignatureDto()
        {
            Jumps = new List<JumpDto>();
        }
    }
}
