namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 判断指定的字符是否为符号字符。
        /// </summary>
        /// <param name="c">要判断的字符。</param>
        /// <returns>如果字符为符号字符，则为 <c>true</c>；否则为 <c>false</c>。</returns>
        public static bool IsSymbol(this char c)
        {
            return char.IsSymbol(c);
        }
    }
}
