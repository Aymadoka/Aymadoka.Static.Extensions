using System.Globalization;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        /// <summary>
        /// 将 <see cref="float"/> 类型的数值转换为科学计数法格式的字符串。
        /// </summary>
        /// <param name="source">需要转换的原始 <see cref="float"/> 数值。</param>
        /// <param name="decimalPlaces">保留的小数位数，默认为 2。</param>
        /// <returns>转换后的科学计数法字符串。</returns>
        public static string ToScientificNotation(this float source, int decimalPlaces = 2)
        {
            return source.ToScientificNotation(decimalPlaces, null);
        }

        /// <summary>
        /// 将 <see cref="float"/> 类型的数值转换为科学计数法格式的字符串，并指定区域信息。
        /// </summary>
        /// <param name="source">需要转换的原始 <see cref="float"/> 数值。</param>
        /// <param name="decimalPlaces">保留的小数位数。</param>
        /// <param name="culture">用于格式化的 <see cref="CultureInfo"/>，默认为 "zh-CN"。</param>
        /// <returns>转换后的科学计数法字符串。</returns>
        public static string ToScientificNotation(this float source, int decimalPlaces, CultureInfo? culture)
        {
            culture ??= new CultureInfo("zh-CN");
            return source.ToString($"E{decimalPlaces}", culture);
        }

        /// <summary>
        /// 将 <see cref="double"/> 类型的数值转换为科学计数法格式的字符串。
        /// </summary>
        /// <param name="source">需要转换的原始 <see cref="double"/> 数值。</param>
        /// <param name="decimalPlaces">保留的小数位数，默认为 2。</param>
        /// <returns>转换后的科学计数法字符串。</returns>
        public static string ToScientificNotation(this double source, int decimalPlaces = 2)
        {
            return source.ToScientificNotation(decimalPlaces, null);
        }

        /// <summary>
        /// 将 <see cref="double"/> 类型的数值转换为科学计数法格式的字符串，并指定区域信息。
        /// </summary>
        /// <param name="source">需要转换的原始 <see cref="double"/> 数值。</param>
        /// <param name="decimalPlaces">保留的小数位数。</param>
        /// <param name="culture">用于格式化的 <see cref="CultureInfo"/>，默认为 "zh-CN"。</param>
        /// <returns>转换后的科学计数法字符串。</returns>
        public static string ToScientificNotation(this double source, int decimalPlaces, CultureInfo? culture)
        {
            culture ??= new CultureInfo("zh-CN");
            return source.ToString($"E{decimalPlaces}", culture);
        }

        /// <summary>
        /// 将 <see cref="decimal"/> 类型的数值转换为科学计数法格式的字符串。
        /// </summary>
        /// <param name="source">需要转换的原始 <see cref="decimal"/> 数值。</param>
        /// <param name="decimalPlaces">保留的小数位数，默认为 2。</param>
        /// <returns>转换后的科学计数法字符串。</returns>
        public static string ToScientificNotation(this decimal source, int decimalPlaces = 2)
        {
            return source.ToScientificNotation(decimalPlaces, null);
        }

        /// <summary>
        /// 将 <see cref="decimal"/> 类型的数值转换为科学计数法格式的字符串，并指定区域信息。
        /// </summary>
        /// <param name="source">需要转换的原始 <see cref="decimal"/> 数值。</param>
        /// <param name="decimalPlaces">保留的小数位数。</param>
        /// <param name="culture">用于格式化的 <see cref="CultureInfo"/>，默认为 "zh-CN"。</param>
        /// <returns>转换后的科学计数法字符串。</returns>
        public static string ToScientificNotation(this decimal source, int decimalPlaces, CultureInfo? culture)
        {
            culture ??= new CultureInfo("zh-CN");
            return source.ToString($"E{decimalPlaces}", culture);
        }
    }
}
