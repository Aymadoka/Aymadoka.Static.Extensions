using System;

namespace Aymadoka.Static.DateTimeExtension;

public static partial class DateTimeExtensions
{
    /// <summary>判断指定日期是否为周末（星期六或星期日）</summary>
    /// <param name="this">源日期</param>
    /// <returns>如果是周末，则返回 <c>true</c>；否则返回 <c>false</c></returns>
    public static bool IsWeekendDay(this DateTime @this)
    {
        var result = @this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday;
        return result;
    }
}
