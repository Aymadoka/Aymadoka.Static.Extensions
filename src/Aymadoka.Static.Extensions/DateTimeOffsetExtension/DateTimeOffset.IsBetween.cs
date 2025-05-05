using System;

namespace Aymadoka.Static.DateTimeOffsetExtension;

public static partial class DateTimeOffsetExtensions
{
    /// <summary>
    /// 判断 <see cref="DateTimeOffset"/> 是否在指定的时间范围内。
    /// </summary>
    /// <param name="this">要检查的 <see cref="DateTimeOffset"/>。</param>
    /// <param name="start">范围的开始时间。</param>
    /// <param name="end">范围的结束时间。</param>
    /// <returns>如果在范围内，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
    public static bool IsBetween(this DateTimeOffset @this, DateTimeOffset start, DateTimeOffset end)
    {
        return @this >= start && @this <= end;
    }
}
