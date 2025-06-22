using System.Globalization;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将字符串转换为当前区域性的标题格式（每个单词首字母大写）。
        /// </summary>
        /// <param name="this">要转换的字符串。</param>
        /// <returns>标题格式的字符串，如果输入为 null 则返回 null。</returns>
        public static string? ToTitleCase(this string? @this)
        {
            var cultureInfo = CultureInfo.CurrentCulture;
            var result = @this.ToTitleCase(cultureInfo);

            return result;
        }

        /// <summary>
        /// 将字符串转换为指定区域性的标题格式（每个单词首字母大写）。
        /// </summary>
        /// <param name="this">要转换的字符串。</param>
        /// <param name="cultureInfo">用于转换的区域性信息。</param>
        /// <returns>标题格式的字符串，如果输入为 null 或空白则返回原字符串。</returns>
        public static string? ToTitleCase(this string? @this, CultureInfo cultureInfo)
        {
            if (@this.IsNullOrWhiteSpace())
            {
                return @this;
            }

            return cultureInfo.TextInfo.ToTitleCase(@this);
        }
    }
}
