using System;

namespace Aymadoka.Static.DateTimeExtension;

public static partial class DateTimeExtensions
{
    public static TimeSpan Elapsed(this DateTime datetime)
    {
        return DateTime.UtcNow - datetime;
    }
}
