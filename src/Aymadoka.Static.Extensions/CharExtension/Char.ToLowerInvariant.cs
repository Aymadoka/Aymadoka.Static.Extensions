namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 将指定的字符转换为小写形式，使用不变的区域性规则。
        /// </summary>
        /// <param name="c">要转换的小写字符。</param>
        /// <returns>转换为小写形式的字符。</returns>
        public static char ToLowerInvariant(this char c)
        {
            return char.ToLowerInvariant(c);
        }
    }
}
