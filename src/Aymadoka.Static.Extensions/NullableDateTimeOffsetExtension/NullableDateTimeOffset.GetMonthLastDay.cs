using Aymadoka.Static.DateTimeOffsetExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public static partial class NullableDateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTimeOffset?"/> 所在月份的最后一天。
        /// </summary>
        /// <param name="this">可空的 <see cref="DateTimeOffset"/> 实例。</param>
        /// <returns>如果 <paramref name="this"/> 不为 null，则返回该月份的最后一天；否则返回 null。</returns>
        public static DateTimeOffset? GetMonthLastDay([NotNullIfNotNull(nameof(@this))] this DateTimeOffset? @this)
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
