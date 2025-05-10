using Aymadoka.Static.DateTimeOffsetExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public static partial class NullableDateTimeOffsetExtensions
    {
        /// <summary>
        /// 移除可空 <see cref="DateTimeOffset"/> 的时间部分，仅保留日期部分。
        /// </summary>
        /// <param name="this">要移除时间部分的可空 <see cref="DateTimeOffset"/>。</param>
        /// <returns>
        /// 如果 <paramref name="this"/> 不为 <c>null</c>，则返回仅包含日期部分的 <see cref="DateTimeOffset"/>；
        /// 否则返回 <c>null</c>。
        /// </returns>
        public static DateTimeOffset? RemoveTime([NotNullIfNotNull(nameof(@this))] this DateTimeOffset? @this)
        {
            if (@this == null)
            {
                return null;
            }

            var result = @this.Value.RemoveTime();
            return result;
        }
    }
}
