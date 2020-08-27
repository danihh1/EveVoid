using EveVoid.Models.EveObjects;

namespace EveVoid.Models.Navigation.Masks
{
    public class Mask
    {
        public int Id { get; set; }
        public int? CorporationId { get; set; }
        public int? AllianceId { get; set; }
        public virtual Corporation Corporation { get; set; }
        public virtual Alliance Alliance { get; set; }
    }
}
