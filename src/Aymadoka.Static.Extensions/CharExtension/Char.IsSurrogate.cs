namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 扩展方法，判断指定的字符是否为代理项（代理对的一部分）。
        /// </summary>
        /// <param name="c">要检查的字符。</param>
        /// <returns>如果字符是代理项，则为 <c>true</c>；否则为 <c>false</c>。</returns>
        public static bool IsSurrogate(this char c)
        {
            return char.IsSurrogate(c);
        }
    }
}
