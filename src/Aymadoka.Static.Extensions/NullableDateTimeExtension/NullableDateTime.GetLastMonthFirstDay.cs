using Aymadoka.Static.DateTimeExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>获取可空 <see cref="DateTime"/> 所在日期的上一个月的第一天日期</summary>
        /// <param name="this">要获取上一个月第一天的可空 <see cref="DateTime"/></param>
        /// <returns>
        /// 如果 <paramref name="this"/> 不为 <c>null</c>，则返回该日期上一个月的第一天 <see cref="DateTime"/>；
        /// 如果 <paramref name="this"/> 为 <c>null</c>，则返回 <c>null</c>
        /// </returns>
        /// <remarks>
        /// - 如果输入为 <c>null</c>，方法将直接返回 <c>null</c>
        /// - 如果输入为有效日期，方法将返回该日期上一个月的第一天
        /// </remarks>
        public static DateTime? GetLastMonthFirstDay([NotNullIfNotNull(nameof(@this))] this DateTime? @this)
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
