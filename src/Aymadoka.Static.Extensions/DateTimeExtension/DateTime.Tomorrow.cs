using System;

namespace Aymadoka.Static.NullableDateTimeExtension;

public static partial class DateTimeExtensions
{
    /// <summary>获取指定日期的下一天</summary>
    /// <param name="this">源日期</param>
    /// <returns>源日期的下一天，保留时间部分</returns>
    public static DateTime Tomorrow(this DateTime @this)
    {
        var result = @this.AddDays(1);
        return result;
    }
}
