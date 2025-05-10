using Aymadoka.Static.DateTimeExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>移除可空 <see cref="DateTime"/> 的时间部分，仅保留日期部分</summary>
        /// <param name="this">要移除时间部分的可空 <see cref="DateTime"/></param>
        /// <returns>
        /// 如果 <paramref name="this"/> 不为 <c>null</c>，则返回仅包含日期部分的 <see cref="DateTime"/>；
        /// 如果 <paramref name="this"/> 为 <c>null</c>，则返回 <c>null</c>
        /// </returns>
        /// <remarks>
        /// - 如果输入为 <c>null</c>，方法将直接返回 <c>null</c>
        /// - 如果输入包含时间部分，方法将移除时间部分，仅保留日期部分
        /// </remarks>
        public static DateTime? RemoveTime([NotNullIfNotNull(nameof(@this))] this DateTime? @this)
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
