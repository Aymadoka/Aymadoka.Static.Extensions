using Aymadoka.Static.DateTimeExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    /// <summary>
    /// 获取指定可空 <see cref="DateTime"/> 所在月份的最后一天。
    /// </summary>
    /// <param name="this">要获取最后一天的可空 <see cref="DateTime"/> 实例。</param>
    /// <returns>
    /// 如果 <paramref name="this"/> 为 <c>null</c>，则返回 <c>null</c>；
    /// 否则返回该日期所在月份的最后一天的 <see cref="DateTime"/>。
    /// </returns>
    public static partial class NullableDateTimeExtensions
    {
        public static DateTime? GetMonthLastDay([NotNullIfNotNull(nameof(@this))] this DateTime? @this)
        {
            if (@this == null)
            {
                return null;
            }

            var result = @this.Value.GetMonthLastDay();
            return result;
        }
    }
}
