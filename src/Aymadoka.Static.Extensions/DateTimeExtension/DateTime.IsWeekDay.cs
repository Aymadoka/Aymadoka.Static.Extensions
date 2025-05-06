using System;

namespace Aymadoka.Static.DateTimeExtension;

public static partial class DateTimeExtensions
{
    public static bool IsWeekDay(this DateTime @this)
    {
        var result = !@this.IsWeekendDay();
        return result;
    }
}
