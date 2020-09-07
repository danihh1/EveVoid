namespace EveVoid.Dto
{
    public class WormholeTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double MaxMass { get; set; }
        public double MaxJump { get; set; }
        public string Duration { get; set; }
        public int LeadsToId { get; set; }
        public string LeadsTo { get; set; }
    }

    public class WormholeTypeMapDto : WormholeTypeDto
    {
        public string Color { get; set; }
    }
}
