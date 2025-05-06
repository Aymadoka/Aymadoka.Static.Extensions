using System;

namespace Aymadoka.Static.DateTimeExtension;

public static partial class DateTimeExtensions
{
    /// <summary>获取指定日期所在月份的倒数第二天</summary>
    /// <param name="this">源日期</param>
    /// <returns>源日期所在月份的倒数第二天，保留时间部分</returns>
    public static DateTime GetLastOfMonthSecondDay(this DateTime @this)
    {
        var result = @this.CurrentMonthFirstDay().AddMonths(1).AddDays(-2);
        return result;
    }
}
