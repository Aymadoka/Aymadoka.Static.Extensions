using System.Globalization;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        /// <summary>将小数值转换为科学计数法格式的字符串</summary>
        /// <param name="source">需要转换的原始小数值</param>
        /// <param name="decimalPlaces">保留的小数位数，默认为 2</param>
        /// <returns>转换后的科学计数法字符串</returns>
        public static string ToScientificNotation(this float source, int decimalPlaces = 2)
        {
            return source.ToScientificNotation(decimalPlaces, null);
        }

        public static string ToScientificNotation(this float source, int decimalPlaces, CultureInfo? culture)
        {
            culture ??= new CultureInfo("zh-CN");
            return source.ToString($"E{decimalPlaces}", culture);
        }

        public static string ToScientificNotation(this double source, int decimalPlaces = 2)
        {
            return source.ToScientificNotation(decimalPlaces, null);
        }

        public static string ToScientificNotation(this double source, int decimalPlaces, CultureInfo? culture)
        {
            culture ??= new CultureInfo("zh-CN");
            return source.ToString($"E{decimalPlaces}", culture);
        }

        public static string ToScientificNotation(this decimal source, int decimalPlaces = 2)
        {
            return source.ToScientificNotation(decimalPlaces, null);
        }

        public static string ToScientificNotation(this decimal source, int decimalPlaces, CultureInfo? culture)
        {
            culture ??= new CultureInfo("zh-CN");
            return source.ToString($"E{decimalPlaces}", culture);
        }
    }
}
