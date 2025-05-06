using System;

namespace Aymadoka.Static.DateTimeExtension;

public static partial class DateTimeExtensions
{
    public static DateTime CurrentWeekLastDay(this DateTime @this)
    {
        var kind = @this.Kind;
        var result = new DateTime(@this.Year, @this.Month, @this.Day, 0, 0, 0, kind).AddDays(6 - (int)@this.DayOfWeek);
        return result;
    }
}
