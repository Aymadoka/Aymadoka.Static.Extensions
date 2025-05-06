using System;

namespace Aymadoka.Static.NullableDateTimeExtension;

public static partial class NullableDateTimeExtensions
{
    public static DateTime CurrentWeekFirstDay(this DateTime @this)
    {
        var kind = @this.Kind;
        var result = new DateTime(@this.Year, @this.Month, @this.Day, 0, 0, 0, kind).AddDays(-(int)@this.DayOfWeek);
        return result;
    }
}
