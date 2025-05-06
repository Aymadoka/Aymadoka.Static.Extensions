using System;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableDateTimeOffsetExtension;

public static partial class NullableDateTimeOffsetExtensions
{
    /// <summary>
    /// 使用指定的格式将可空的 <see cref="DateTimeOffset"/> 转换为其字符串表示形式。
    /// </summary>
    /// <param name="this">要转换的可空 <see cref="DateTimeOffset"/>。</param>
    /// <param name="format">标准或自定义的日期和时间格式字符串。如果为 <c>null</c>，将使用默认格式。</param>
    /// <returns>
    /// 如果 <paramref name="this"/> 不为 <c>null</c>，则返回其字符串表示形式；
    /// 否则返回 <c>null</c>。
    /// </returns>
    public static string? ToString([NotNullIfNotNull(nameof(@this))] this DateTimeOffset? @this, string format)
    {
        if (@this == null)
        {
            return null;
        }

        var result = @this.Value.ToString(format);
        return result;
    }
}
