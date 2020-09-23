using EveVoid.Models.EveObjects;

namespace EveVoid.Models.Navigation.MapObjects
{
    public class DscanShip
    {
        public int Id { get; set; }
        public int DscanId { get; set; }
        public int ShipTypeId { get; set; }
        public string ShipName { get; set; }
        
        public virtual Dscan Dscan { get; set; }
        public virtual ItemType ShipType { get; set; }
    }
}
