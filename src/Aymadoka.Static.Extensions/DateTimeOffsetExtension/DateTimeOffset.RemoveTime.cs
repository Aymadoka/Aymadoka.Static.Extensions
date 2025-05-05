using System;

namespace Aymadoka.Static.DateTimeOffsetExtension;

public static partial class DateTimeOffsetExtensions
{
    /// <summary>
    /// 移除 <see cref="DateTimeOffset"/> 的时间部分，仅保留日期部分。
    /// </summary>
    /// <param name="this">要移除时间部分的 <see cref="DateTimeOffset"/>。</param>
    /// <returns>仅包含日期部分的 <see cref="DateTimeOffset"/>。</returns>
    /// <remarks>
    ///     <list type="bullet">
    ///         <item>返回的 <see cref="DateTimeOffset"/> 的时间部分将被设置为 00:00:00。</item>
    ///         <item>保留原始的时区偏移量。/item> 
    ///     </list>
    /// </remarks>
    public static DateTimeOffset RemoveTime(this DateTimeOffset @this)
    {
        var timeOfDay = @this.TimeOfDay;
        var result = @this - timeOfDay;
        return result;
    }
}
