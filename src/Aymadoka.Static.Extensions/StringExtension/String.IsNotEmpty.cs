namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断字符串是否不为空字符串（不等于 <see cref="string.Empty"/>）。
        /// </summary>
        /// <param name="this">要判断的字符串。</param>
        /// <returns>如果字符串不为空字符串，则返回 <c>true</c>；否则返回 <c>false</c>。</returns>
        public static bool IsNotEmpty(this string? @this)
        {
            return string.Empty != @this;
        }
    }
}
