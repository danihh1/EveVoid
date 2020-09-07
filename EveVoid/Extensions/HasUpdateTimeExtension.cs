using EveVoid.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Extensions
{
    public static class HasUpdateTimeExtension
    {
        public static bool PassedMoreThan(this IHasUpdateTime obj, int days = 1, int hours = 0, int minutes = 0, int seconds = 0)
        {
            return obj.LastUpdate <= DateTime.UtcNow.AddDays(-1*days).AddHours(-1*hours).AddMinutes(-1*minutes).AddSeconds(-1 * seconds);
        }

        public static bool PassedLessThan(this IHasUpdateTime obj, int days = 0, int hours = 0, int minutes = 0, int seconds = 0)
        {
            var compareDate = DateTime.UtcNow.AddDays(-1 * days).AddHours(-1 * hours).AddMinutes(-1 * minutes).AddSeconds(-1 * seconds);
            return obj.LastUpdate > compareDate;
        }
    }
}
