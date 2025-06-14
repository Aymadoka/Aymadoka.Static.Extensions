using Aymadoka.Static.DateTimeOffsetExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{

    public static partial class NullableDateTimeOffsetExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTimeOffset?"/> 所在月份的第一天。
        /// </summary>
        /// <param name="this">可空的 <see cref="DateTimeOffset"/> 实例。</param>
        /// <returns>
        /// 如果 <paramref name="this"/> 为 null，则返回 null；
        /// 否则返回该日期所在月份的第一天（时间部分与原始值一致）。
        /// </returns>
        public static DateTimeOffset? GetMonthFirstDay([NotNullIfNotNull(nameof(@this))] this DateTimeOffset? @this)
        {
            if (@this == null)
            {
                return null;
            }

            var result = @this.Value.GetMonthFirstDay();
            return result;
        }
    }
}
