using Aymadoka.Static.DateTimeOffsetExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public static partial class NullableDateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取可空 <see cref="DateTimeOffset"/> 的前一天日期。
        /// </summary>
        /// <param name="this">要获取前一天的可空 <see cref="DateTimeOffset"/>。</param>
        /// <returns>
        /// 如果 <paramref name="this"/> 不为 <c>null</c>，则返回前一天的 <see cref="DateTimeOffset"/>；
        /// 否则返回 <c>null</c>。
        /// </returns>
        public static DateTimeOffset? Yesterday([NotNullIfNotNull(nameof(@this))] this DateTimeOffset? @this)
        {
            if (@this == null)
            {
                return null;
            }

            var result = @this.Value.Yesterday();
            return result;
        }
    }
}
