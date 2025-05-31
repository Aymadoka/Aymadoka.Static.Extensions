namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 判断指定的两个字符是否形成有效的代理项对（高代理项和低代理项）。
        /// </summary>
        /// <param name="highSurrogate">高代理项字符。</param>
        /// <param name="lowSurrogate">低代理项字符。</param>
        /// <returns>如果两个字符形成有效的代理项对，则为 <c>true</c>；否则为 <c>false</c>。</returns>
        public static bool IsSurrogatePair(this char highSurrogate, char lowSurrogate)
        {
            return char.IsSurrogatePair(highSurrogate, lowSurrogate);
        }
    }
}
