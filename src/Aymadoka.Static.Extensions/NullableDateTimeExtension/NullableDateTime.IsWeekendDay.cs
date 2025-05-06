using Aymadoka.Static.DateTimeExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeExtension;

public static partial class NullableDateTimeExtensions
{
    /// <summary>判断可空 <see cref="DateTime"/> 是否为周末</summary>
    /// <param name="this">要判断的可空 <see cref="DateTime"/></param>
    /// <returns>
    /// 如果 <paramref name="this"/> 不为 <c>null</c> 且为周六或周日，则返回 <c>true</c>；
    /// 否则返回 <c>false</c>
    /// </returns>
    /// <remarks>
    /// - 如果输入为 <c>null</c>，方法将返回 <c>false</c>
    /// - 如果输入为有效日期，方法将判断该日期是否为周六或周日
    /// </remarks>
    public static bool IsWeekendDay([NotNullWhen(true)] this DateTime? @this)
    {
        if (@this == null)
        {
            return false;
        }

        var result = @this.Value.IsWeekendDay();
        return result;
    }
}
