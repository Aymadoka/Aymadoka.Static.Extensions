namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 返回指定字符串 <paramref name="value"/> 在当前字符串中首次出现后面的所有字符。
        /// 如果未找到 <paramref name="value"/>，则返回空字符串。
        /// </summary>
        /// <param name="this">要搜索的原始字符串。</param>
        /// <param name="value">要查找的子字符串。</param>
        /// <returns>在 <paramref name="value"/> 之后的字符串；如果未找到，则返回空字符串。</returns>
        public static string GetAfter(this string @this, string value)
        {
            if (@this.IndexOf(value) == -1)
            {
                return "";
            }

            return @this.Substring(@this.IndexOf(value) + value.Length);
        }
    }
}
