namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 返回指定字符串在当前字符串中第一次出现之前的所有字符。
        /// </summary>
        /// <param name="this">要搜索的字符串。</param>
        /// <param name="value">要查找的子字符串。</param>
        /// <returns>如果找到，则返回 value 之前的所有字符；否则返回空字符串。</returns>
        public static string GetBefore(this string @this, string value)
        {
            if (@this.IndexOf(value) == -1)
            {
                return "";
            }
            return @this.Substring(0, @this.IndexOf(value));
        }
    }
}
