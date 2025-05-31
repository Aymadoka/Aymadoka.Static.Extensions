namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 扩展方法，判断指定的字符是否为数字字符。
        /// </summary>
        /// <param name="c">要判断的字符。</param>
        /// <returns>如果字符为数字字符，则返回 true；否则返回 false。</returns>
        public static bool IsNumber(this char c)
        {
            return char.IsNumber(c);
        }
    }
}
