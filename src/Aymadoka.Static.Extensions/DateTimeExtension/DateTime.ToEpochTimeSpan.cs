using System;

namespace Aymadoka.Static.DateTimeExtension
{
    public static partial class DateTimeExtensions
    {
        public static TimeSpan ToEpochTimeSpan(this DateTime @this)
        {
            return @this.Subtract(DateTime.UnixEpoch);
        }
    }
}
