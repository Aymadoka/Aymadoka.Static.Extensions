using System.Globalization;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    /// <summary>将字符串转换为标题格式（每个单词首字母大写）</summary>
    /// <param name="value">要转换的字符串</param>
    /// <returns>转换后的字符串；如果输入为 null 或仅包含空白字符，则返回原字符串</returns>
    public static string? ToTitleCase(this string? value)
    {
        if (value.IsNullOrWhiteSpace())
        {
            return value;
        }

        var textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(value.ToLower());
    }
}
