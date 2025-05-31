namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 将指定的字符转换为其大写等效字符，使用不变区域性规则。
        /// </summary>
        /// <param name="c">要转换的大写字符。</param>
        /// <returns>转换为大写形式的字符。</returns>
        public static char ToUpperInvariant(this char c)
        {
            return char.ToUpperInvariant(c);
        }
    }
}
