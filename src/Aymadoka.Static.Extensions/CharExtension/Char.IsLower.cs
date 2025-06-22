namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 判断指定的字符是否为小写字母。
        /// </summary>
        /// <param name="c">要判断的字符。</param>
        /// <returns>如果字符为小写字母，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsLower(this char c)
        {
            return char.IsLower(c);
        }
    }
}
