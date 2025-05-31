namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 判断指定的字符是否为 Unicode 高代理项（high surrogate）。
        /// </summary>
        /// <param name="c">要检查的字符。</param>
        /// <returns>如果字符是高代理项，则为 <c>true</c>；否则为 <c>false</c>。</returns>
        public static bool IsHighSurrogate(this char c)
        {
            return char.IsHighSurrogate(c);
        }
    }
}
