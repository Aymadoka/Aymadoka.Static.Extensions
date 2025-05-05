using System.Globalization;
using System.Numerics;

namespace Aymadoka.Static.FloatingPointExtension
{
    public static partial class NumberExtensions
    {
        /// <summary>将小数值转换为科学计数法格式的字符串</summary>
        /// <param name="source">需要转换的原始小数值</param>
        /// <param name="decimalPlaces">保留的小数位数，默认为 2</param>
        /// <returns>转换后的科学计数法字符串</returns>
        public static string ToScientificNotation<T>(this T source, int decimalPlaces = 2) where T : struct, IFloatingPoint<T>
        {
            return source.ToScientificNotation(decimalPlaces, null);
        }

        public static string ToScientificNotation<T>(this T source, int decimalPlaces, CultureInfo? culture) where T : struct, IFloatingPoint<T>
        {
            culture ??= new CultureInfo("zh-CN");
            return source.ToString($"E{decimalPlaces}", culture);
        }
    }
}
