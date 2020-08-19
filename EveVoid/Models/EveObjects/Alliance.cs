using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.EveObjects
{
    public class Alliance: HasUpdateTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }
        public virtual List<Corporation> Corporations { get; set; }

        public Alliance()
        {
            Corporations = new List<Corporation>();
        }
    }
}
