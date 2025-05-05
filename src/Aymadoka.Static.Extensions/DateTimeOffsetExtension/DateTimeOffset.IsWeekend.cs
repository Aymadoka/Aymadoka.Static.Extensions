using System;

namespace Aymadoka.Static.DateTimeOffsetExtension;

public static partial class DateTimeOffsetExtensions
{
    /// <summary>
    /// 判断 <see cref="DateTimeOffset"/> 是否为周末。
    /// </summary>
    /// <param name="this">要判断的 <see cref="DateTimeOffset"/>。</param>
    /// <returns>如果是周六或周日，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
    public static bool IsWeekend(this DateTimeOffset @this)
    {
        var result = @this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday;
        return result;
    }
}
