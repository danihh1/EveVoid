using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Extensions
{
    public static class HasUpdateTimeExtension
    {
        public static bool ShouldUpdate(this IHasUpdateTime obj, int days = 1, int hours = 0, int minutes = 0, int seconds = 0)
        {
            return obj.LastUpdate <= DateTime.Now.AddDays(-1*days).AddHours(-1*hours).AddMinutes(-1*minutes).AddSeconds(-1 * seconds);
        }

        public static bool PassedLessThan(this IHasUpdateTime obj, int days = 0, int hours = 0, int minutes = 0, int seconds = 0)
        {
            return obj.LastUpdate <= DateTime.Now.AddDays(days).AddHours(hours).AddMinutes(minutes).AddSeconds(seconds);
        }
    }
}
