namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>判断字符串是否不为 null 且不全为空白字符</summary>
        /// <param name="source">要检查的字符串</param>
        /// <returns>如果字符串不为 null 且不全为空白字符，则返回 true；否则返回 false</returns>
        public static bool IsNotNullOrWhiteSpace(this string? source)
        {
            return !source.IsNullOrWhiteSpace();
        }
    }
}
