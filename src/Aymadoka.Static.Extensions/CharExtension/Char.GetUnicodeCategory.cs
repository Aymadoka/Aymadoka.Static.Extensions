using System.Globalization;

namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 获取指定字符的 Unicode 类别。
        /// </summary>
        /// <param name="c">要获取 Unicode 类别的字符。</param>
        /// <returns>指定字符的 <see cref="UnicodeCategory"/>。</returns>
        public static UnicodeCategory GetUnicodeCategory(this char c)
        {
            return char.GetUnicodeCategory(c);
        }
    }
}
