using EveVoid.Models.Shared;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.EveObjects
{
    public class ItemType : IHasUpdateTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int ItemGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Mass { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ItemGroup ItemGroup { get; set; }

    }
}
