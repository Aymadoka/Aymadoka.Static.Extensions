using System.Globalization;

namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 将指定字符转换为大写形式，使用指定的区域性信息。
        /// </summary>
        /// <param name="c">要转换的大写字符。</param>
        /// <param name="culture">区域性信息。</param>
        /// <returns>转换为大写形式的字符。</returns>
        public static char ToUpper(this char c, CultureInfo culture)
        {
            return char.ToUpper(c, culture);
        }

        /// <summary>
        /// 将指定字符转换为大写形式，使用当前区域性信息。
        /// </summary>
        /// <param name="c">要转换的大写字符。</param>
        /// <returns>转换为大写形式的字符。</returns>
        public static char ToUpper(this char c)
        {
            return char.ToUpper(c);
        }
    }
}
