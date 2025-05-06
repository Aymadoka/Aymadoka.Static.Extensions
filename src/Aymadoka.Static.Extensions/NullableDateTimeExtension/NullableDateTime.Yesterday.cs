using Aymadoka.Static.DateTimeExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeExtension;

public static partial class NullableDateTimeExtensions
{
    /// <summary>获取可空 <see cref="DateTime"/> 的前一天日期</summary>
    /// <param name="this">要获取前一天的可空 <see cref="DateTime"/></param>
    /// <returns>
    /// 如果 <paramref name="this"/> 不为 <c>null</c>，则返回前一天的 <see cref="DateTime"/>；
    /// 如果 <paramref name="this"/> 为 <c>null</c>，则返回 <c>null</c>
    /// </returns>
    /// <remarks>
    /// - 如果输入为 <c>null</c>，方法将直接返回 <c>null</c>
    /// - 如果输入为有效日期，方法将返回该日期的前一天
    /// </remarks>
    public static DateTime? Yesterday([NotNullIfNotNull(nameof(@this))] this DateTime? @this)
    {
        if (@this == null)
        {
            return null;
        }

        var result = @this.Value.Yesterday();
        return result;
    }
}
