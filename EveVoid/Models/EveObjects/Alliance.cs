using EveVoid.Models.Navigation;
using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using EveVoid.Models.Navigation.Masks;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.EveObjects
{
    public class Alliance: IHasUpdateTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }
        public int MaskId { get; set; }

        public virtual List<Corporation> Corporations { get; set; }
        public virtual Mask Mask { get; set; }

        public Alliance()
        {
            Corporations = new List<Corporation>();
        }
    }
}
