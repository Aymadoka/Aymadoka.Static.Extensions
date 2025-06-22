namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 扩展方法，判断指定的字符是否为低代理项（low surrogate）。
        /// 低代理项用于 UTF-16 编码中表示代理对的后半部分。
        /// </summary>
        /// <param name="c">要检查的字符。</param>
        /// <returns>如果字符是低代理项，则为 true；否则为 false。</returns>
        public static bool IsLowSurrogate(this char c)
        {
            return char.IsLowSurrogate(c);
        }
    }
}
