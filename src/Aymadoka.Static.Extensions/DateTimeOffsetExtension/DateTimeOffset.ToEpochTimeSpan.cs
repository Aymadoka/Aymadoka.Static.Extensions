using System;

namespace Aymadoka.Static.DateTimeOffsetExtension;

public static partial class DateTimeOffsetExtensions
{
    public static TimeSpan ToEpochTimeSpan(this DateTimeOffset @this)
    {
        return @this.Subtract(DateTimeOffset.UnixEpoch);
    }
}
