using System;

namespace Aymadoka.Static.DateTimeExtension;

public static partial class DateTimeExtensions
{
    public static bool IsFuture(this DateTime @this)
    {
        return @this > DateTime.Now;
    }
}
