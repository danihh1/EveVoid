using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.Shared
{
    public interface IHasUpdateTime
    {
        public DateTime LastUpdate { get;set; }
    }
}
