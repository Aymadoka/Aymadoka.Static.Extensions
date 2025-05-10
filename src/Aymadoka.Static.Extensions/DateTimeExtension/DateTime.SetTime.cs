using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        public static DateTime SetTime(this DateTime current, int hour)
        {
            var result = SetTime(current, hour, 0, 0, 0);
            return result;
        }

        public static DateTime SetTime(this DateTime current, int hour, int minute)
        {
            var result = SetTime(current, hour, minute, 0, 0);
            return result;
        }

        public static DateTime SetTime(this DateTime current, int hour, int minute, int second)
        {
            var result = SetTime(current, hour, minute, second, 0);
            return result;
        }

        public static DateTime SetTime(this DateTime @this, int hour, int minute, int second, int millisecond)
        {
            var result = new DateTime(@this.Year, @this.Month, @this.Day, hour, minute, second, millisecond, @this.Kind);
            return result;
        }
    }
}
