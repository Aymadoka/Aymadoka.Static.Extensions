using Aymadoka.Static.DateTimeOffsetExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension;

public static partial class NullableDateTimeOffsetExtensions
{
    /// <summary>
    /// 判断可空 <see cref="DateTimeOffset"/> 是否为周末。
    /// </summary>
    /// <param name="this">要判断的可空 <see cref="DateTimeOffset"/>。</param>
    /// <returns>
    /// 如果 <paramref name="this"/> 不为 <c>null</c> 且为周六或周日，则返回 <c>true</c>；
    /// 否则返回 <c>false</c>。
    /// </returns>
    public static bool IsWeekend([NotNullWhen(true)] this DateTimeOffset? @this)
    {
        if (@this == null)
        {
            return false;
        }

        var result = @this.Value.IsWeekend();
        return result;
    }
}
