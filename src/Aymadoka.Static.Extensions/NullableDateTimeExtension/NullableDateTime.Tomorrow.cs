using Aymadoka.Static.DateTimeExtension;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 获取指定 <see cref="DateTime?"/> 的明天日期。
        /// 如果参数为 null，则返回 null。
        /// </summary>
        /// <param name="this">可空的 <see cref="DateTime"/> 实例。</param>
        /// <returns>明天的 <see cref="DateTime"/>，如果参数为 null，则返回 null。</returns>
        public static DateTime? Tomorrow([NotNullIfNotNull(nameof(@this))] this DateTime? @this)
        {
            if (@this == null)
            {
                return null;
            }

            var result = @this.Value.Tomorrow();
            return result;
        }
    }
}
