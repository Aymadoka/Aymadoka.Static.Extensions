namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 判断指定的字符是否为十进制数字字符。
        /// </summary>
        /// <param name="c">要判断的字符。</param>
        /// <returns>如果字符为十进制数字字符，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsDigit(this char c)
        {
            return char.IsDigit(c);
        }
    }
}
