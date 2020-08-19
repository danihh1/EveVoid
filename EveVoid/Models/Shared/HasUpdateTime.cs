using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.Shared
{
    public interface HasUpdateTime
    {
        public DateTime LastUpdate { get;set; }
    }
}
