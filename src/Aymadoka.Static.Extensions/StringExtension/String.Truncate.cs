namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 截断字符串到指定最大长度，并在末尾添加默认后缀"..."。
        /// </summary>
        /// <param name="this">要截断的字符串。</param>
        /// <param name="maxLength">最大长度（包含后缀）。</param>
        /// <returns>截断后的字符串，如果原字符串长度小于等于最大长度则返回原字符串。</returns>
        public static string Truncate(this string @this, int maxLength)
        {
            const string suffix = "...";

            if (@this == null || @this.Length <= maxLength)
            {
                return @this;
            }

            int strLength = maxLength - suffix.Length;
            return @this.Substring(0, strLength) + suffix;
        }

        /// <summary>
        /// 截断字符串到指定最大长度，并在末尾添加自定义后缀。
        /// </summary>
        /// <param name="this">要截断的字符串。</param>
        /// <param name="maxLength">最大长度（包含后缀）。</param>
        /// <param name="suffix">自定义后缀。</param>
        /// <returns>截断后的字符串，如果原字符串长度小于等于最大长度则返回原字符串。</returns>
        public static string Truncate(this string @this, int maxLength, string suffix)
        {
            if (@this == null || @this.Length <= maxLength)
            {
                return @this;
            }

            int strLength = maxLength - suffix.Length;
            return @this.Substring(0, strLength) + suffix;
        }
    }
}
