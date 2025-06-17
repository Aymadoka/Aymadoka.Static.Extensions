namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将当前字符串与指定的字符串数组连接起来。
        /// </summary>
        /// <param name="this">当前字符串。</param>
        /// <param name="values">要连接的字符串数组。</param>
        /// <returns>连接后的新字符串。</returns>
        public static string ConcatWith(this string @this, params string[] values)
        {
            return string.Concat(@this, string.Concat(values));
        }
    }
}
