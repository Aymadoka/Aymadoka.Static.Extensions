using Aymadoka.Static.DateTimeOffsetExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public static partial class NullableDateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTimeOffset?"/> 的下一个月的第一天。
        /// </summary>
        /// <param name="this">可空的 <see cref="DateTimeOffset"/> 实例。</param>
        /// <returns>下一个月第一天的 <see cref="DateTimeOffset"/>，如果 <paramref name="this"/> 为 null，则返回 null。</returns>
        public static DateTimeOffset? GetNextMonthFirstDay([NotNullIfNotNull(nameof(@this))] this DateTimeOffset? @this)
        {
            if (@this == null)
            {
                return null;
            }

            var result = @this.Value.GetNextMonthFirstDay();
            return result;
        }
    }
}
