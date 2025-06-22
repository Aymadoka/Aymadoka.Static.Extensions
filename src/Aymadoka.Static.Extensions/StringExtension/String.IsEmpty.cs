namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断指定的字符串是否为空字符串（即长度为0）。
        /// </summary>
        /// <param name="this">要判断的字符串。</param>
        /// <returns>如果字符串为""，返回 true；否则返回 false。</returns>
        public static bool IsEmpty(this string? @this)
        {
            return string.Empty == @this;
        }
    }
}
