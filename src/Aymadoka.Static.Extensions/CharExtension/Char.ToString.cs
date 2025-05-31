namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        /// <summary>
        /// 将指定的字符转换为其等效的字符串表示形式。
        /// </summary>
        /// <param name="c">要转换的字符。</param>
        /// <returns>字符的字符串表示形式。</returns>
        public static string ToString(this char c)
        {
            return char.ToString(c);
        }
    }
}
