using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        public static DateTime? GetWeekFirstDay(this DateTime? @this, DayOfWeek weekStartsOn)
        {
            if (@this == null)
            {
                return null;
            }

            var result = @this.Value.GetWeekFirstDay(weekStartsOn);
            return result;
        }

        public static DateTime? GetWeekFirstDay(this DateTime? @this)
        {
            var weekStartsOn = DayOfWeek.Monday;
            var result = @this.GetWeekFirstDay(weekStartsOn);
            return result;
        }
    }
}
