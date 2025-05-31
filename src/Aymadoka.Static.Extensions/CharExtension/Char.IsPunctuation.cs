namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 扩展方法：判断指定字符是否为标点符号。
        /// </summary>
        /// <param name="c">要判断的字符。</param>
        /// <returns>如果字符是标点符号，则返回 true；否则返回 false。</returns>
        public static bool IsPunctuation(this char c)
        {
            return char.IsPunctuation(c);
        }
    }
}
