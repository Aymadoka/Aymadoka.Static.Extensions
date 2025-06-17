namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 如果字符串等于指定的 <paramref name="oldValue"/>，则返回 <paramref name="newValue"/>，否则返回原字符串。
        /// </summary>
        /// <param name="this">要比较的字符串。</param>
        /// <param name="oldValue">要比较的目标字符串。</param>
        /// <param name="newValue">替换后的新字符串。</param>
        /// <returns>如果相等则返回 <paramref name="newValue"/>，否则返回原字符串。</returns>
        public static string ReplaceWhenEquals(this string @this, string oldValue, string newValue)
        {
            return @this == oldValue ? newValue : @this;
        }
    }
}
