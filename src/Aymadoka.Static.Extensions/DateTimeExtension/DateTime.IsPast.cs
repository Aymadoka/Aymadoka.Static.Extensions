using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        public static bool IsPast(this DateTime @this)
        {
            return @this < DateTime.Now;
        }
    }
}
