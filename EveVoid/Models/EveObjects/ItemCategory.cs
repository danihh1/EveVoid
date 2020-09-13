using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveVoid.Models.EveObjects
{
    public class ItemCategory : IHasUpdateTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual List<ItemGroup> ItemGroups { get; set; }

        public ItemCategory()
        {
            ItemGroups = new List<ItemGroup>();
        }
    }
}
