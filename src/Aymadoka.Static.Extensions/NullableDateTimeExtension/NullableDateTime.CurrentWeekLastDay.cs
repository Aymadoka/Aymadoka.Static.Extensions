using Aymadoka.Static.DateTimeExtension;
using System;

namespace Aymadoka.Static.NullableDateTimeExtension;

public static partial class NullableDateTimeExtensions
{
    public static DateTime? CurrentWeekLastDay(this DateTime? @this)
    {
        if (@this == null)
        {
            return null;
        }

        var result = @this.Value.CurrentWeekLastDay();
        return result;
    }
}
