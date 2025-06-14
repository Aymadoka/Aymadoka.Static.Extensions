using Aymadoka.Static.DateTimeOffsetExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    /// <summary>
    /// 获取指定 <see cref="DateTimeOffset?"/> 上个月的第一天。
    /// </summary>
    /// <param name="this">可空的 <see cref="DateTimeOffset"/> 实例。</param>
    /// <returns>
    /// 如果 <paramref name="this"/> 为 <c>null</c>，则返回 <c>null</c>；
    /// 否则返回上个月的第一天的 <see cref="DateTimeOffset"/>。
    /// </returns>
    public static partial class NullableDateTimeOffsetExtensions
    {
        public static DateTimeOffset? GetLastMonthFirstDay([NotNullIfNotNull(nameof(@this))] this DateTimeOffset? @this)
        {
            if (@this == null)
            {
                return null;
            }

            var result = @this.Value.GetLastMonthFirstDay();
            return result;
        }
    }
}
