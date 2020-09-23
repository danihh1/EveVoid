using System;
using System.Collections.Generic;

namespace EveVoid.Dto
{
    public class DscanDto
    {
        public int Id { get; set; }
        public int SolarSystemId { get; set; }
        public DateTime CreationDate { get; set; }

        public List<DscanShipGroupDto> DscanShipGroups { get; set; }
    }

    public class DscanShipGroupDto
    {
        public string GroupName { get; set; }
        public int GroupCount { get; set; }

        public Dictionary<string, int> ShipTypes { get; set; }
    }
}
