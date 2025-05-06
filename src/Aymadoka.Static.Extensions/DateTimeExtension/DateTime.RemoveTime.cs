using System;

namespace Aymadoka.Static.DateTimeExtension;

public static partial class DateTimeExtensions
{
    /// <summary>去除指定日期的时间部分，仅保留日期部分（时间部分为 00:00:00）</summary>
    /// <param name="this">源日期</param>
    /// <returns>仅包含日期部分的 <see cref="DateTime"/> 对象</returns>
    public static DateTime RemoveTime(this DateTime @this)
    {
        var result = @this.Date;
        return result;
    }
}
