using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        public static DateTime? GetWeekLastDay(this DateTime? @this, DayOfWeek weekStartsOn)
        {
            if (@this == null)
            {
                return null;
            }

            var result = @this.Value.GetWeekLastDay();
            return result;
        }

        public static DateTime? GetWeekLastDay(this DateTime? @this)
        {
            var weekStartsOn = DayOfWeek.Monday;
            var result = @this.GetWeekLastDay(weekStartsOn);
            return result;
        }
    }
}
