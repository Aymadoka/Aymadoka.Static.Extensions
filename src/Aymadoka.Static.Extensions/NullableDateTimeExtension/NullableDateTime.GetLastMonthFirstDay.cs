using Aymadoka.Static.DateTimeExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 获取指定可空 <see cref="DateTime"/> 上个月的第一天。
        /// </summary>
        /// <param name="this">要操作的可空 <see cref="DateTime"/> 实例。</param>
        /// <returns>如果 <paramref name="this"/> 为 null，则返回 null；否则返回上个月的第一天。</returns>
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
