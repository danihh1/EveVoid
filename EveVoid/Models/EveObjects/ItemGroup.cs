using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EveVoid.Models.EveObjects
{
    public class ItemGroup : IHasUpdateTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int ItemCategoryId { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ItemCategory ItemCategory { get; set; }
        public virtual List<ItemType> ItemTypes { get; set; }

        public ItemGroup()
        {
            ItemTypes = new List<ItemType>();
        }
    }
}
