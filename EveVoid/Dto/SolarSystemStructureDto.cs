using System;

namespace EveVoid.Dto
{
    public class SolarSystemStructureDto
    {
        public int Id { get; set; }
        public int SolarSystemId { get; set; }
        public int ItemTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ItemTypeName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
