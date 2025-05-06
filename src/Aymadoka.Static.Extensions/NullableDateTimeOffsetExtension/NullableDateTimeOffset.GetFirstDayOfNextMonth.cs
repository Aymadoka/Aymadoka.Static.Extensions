using Aymadoka.Static.DateTimeOffsetExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension;

public static partial class NullableDateTimeOffsetExtensions
{
    /// <summary>
    /// 获取可空 <see cref="DateTimeOffset"/> 所在日期的下一个月的第一天日期。
    /// </summary>
    /// <param name="this">要获取下一个月第一天的可空 <see cref="DateTimeOffset"/>。</param>
    /// <returns>
    /// 如果 <paramref name="this"/> 不为 <c>null</c>，则返回该日期下一个月的第一天 <see cref="DateTimeOffset"/>；
    /// 否则返回 <c>null</c>。
    /// </returns>
    public static DateTimeOffset? GetFirstDayOfNextMonth([NotNullIfNotNull(nameof(@this))] this DateTimeOffset? @this)
    {
        if (@this == null)
        {
            return null;
        }

        var result = @this.Value.GetFirstDayOfNextMonth();
        return result;
    }
}
