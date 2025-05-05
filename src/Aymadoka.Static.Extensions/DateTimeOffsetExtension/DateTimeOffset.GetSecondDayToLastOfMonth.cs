using System;

namespace Aymadoka.Static.DateTimeOffsetExtension;

public static partial class DateTimeOffsetExtensions
{
    /// <summary>
    /// 获取 <see cref="DateTimeOffset"/> 所在月份的倒数第二天日期。
    /// </summary>
    /// <param name="this">要获取倒数第二天的 <see cref="DateTimeOffset"/>。</param>
    /// <returns>所在月份倒数第二天的 <see cref="DateTimeOffset"/>。</returns>
    /// <remarks>
    /// - 返回的 <see cref="DateTimeOffset"/> 保留原始的时区偏移量。
    /// </remarks>
    public static DateTimeOffset GetSecondDayToLastOfMonth(this DateTimeOffset @this)
    {
        var result = @this.CurrentMonthFirstDay().AddMonths(1).AddDays(-2);
        return result;
    }
}
