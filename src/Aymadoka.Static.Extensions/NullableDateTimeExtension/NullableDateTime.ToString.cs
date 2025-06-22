using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>
        /// 将可空 <see cref="DateTime"/> 按指定格式转换为字符串。
        /// </summary>
        /// <param name="this">要格式化的可空 <see cref="DateTime"/> 实例。</param>
        /// <param name="format">日期和时间的格式字符串。</param>
        /// <returns>
        /// 如果 <paramref name="this"/> 为 <c>null</c>，则返回 <c>null</c>；
        /// 否则返回格式化后的字符串。
        /// </returns>
        public static string? ToString([NotNullIfNotNull(nameof(@this))] this DateTime? @this, string? format)
        {
            if (@this == null)
            {
                return null;
            }

            var result = @this.Value.ToString(format);
            return result;
        }
    }
}
