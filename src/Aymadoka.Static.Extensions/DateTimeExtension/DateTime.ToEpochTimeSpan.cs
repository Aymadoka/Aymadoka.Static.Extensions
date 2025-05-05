using System;

namespace Aymadoka.Static.NullableDateTimeExtension;

public static partial class DateTimeExtensions
{
    public static TimeSpan ToEpochTimeSpan(this DateTime @this)
    {
        return @this.Subtract(DateTime.UnixEpoch);
    }
}
