using System.ComponentModel.DataAnnotations.Schema;

namespace EveVoid.Models.Navigation.MapObjects
{
    public class SystemType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
