using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeExtension
{
    public static partial class NullableDateTimeExtensions
    {
        /// <summary>使用指定的格式将可空的 <see cref="DateTime"/> 转换为其字符串表示形式</summary>
        /// <param name="this">要转换的可空 <see cref="DateTime"/></param>
        /// <param name="format">标准或自定义的日期和时间格式字符串。如果为 <c>null</c>，将使用默认格式</param>
        /// <returns>
        /// 如果 <paramref name="this"/> 不为 <c>null</c>，则返回其字符串表示形式；否则返回 <c>null</c>
        /// </returns>
        /// <remarks>
        /// - 如果 <paramref name="this"/> 为 <c>null</c>，方法将返回 <c>null</c>。
        /// - 如果 <paramref name="format"/> 为 <c>null</c>，将使用 <see cref="DateTime"/> 的默认格式。
        /// </remarks>
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
