using System;

namespace EveVoid.Dto
{
    public class SolarSystemTagDto
    {
        public int Id { get; set; }
        public int SolarSystemId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
