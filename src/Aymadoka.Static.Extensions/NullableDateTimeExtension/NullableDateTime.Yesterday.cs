using Aymadoka.Static.DateTimeExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 获取指定可空 <see cref="DateTime"/> 的前一天日期。
        /// 如果参数为 <c>null</c>，则返回 <c>null</c>。
        /// </summary>
        /// <param name="this">要获取前一天的可空 <see cref="DateTime"/> 实例。</param>
        /// <returns>前一天的 <see cref="DateTime"/>，如果参数为 <c>null</c> 则返回 <c>null</c>。</returns>
        public static DateTime? Yesterday([NotNullIfNotNull(nameof(@this))] this DateTime? @this)
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
