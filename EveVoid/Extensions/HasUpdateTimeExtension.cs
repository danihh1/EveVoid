using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Extensions
{
    public static class HasUpdateTimeExtension
    {
        public static bool ShouldUpdate(this HasUpdateTime obj, int days = 1, int hours = 0, int minutes = 0)
        {
            return obj.LastUpdate <= DateTime.Now.AddDays(-1*days).AddHours(-1*hours).AddMinutes(-1*minutes);
        }
    }
}
