namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 替换字符串中指定起始索引和长度的子字符串为指定的新值。
        /// </summary>
        /// <param name="this">要操作的原始字符串。</param>
        /// <param name="startIndex">要替换的起始索引。</param>
        /// <param name="length">要替换的子字符串长度。</param>
        /// <param name="value">用于替换的新字符串。</param>
        /// <returns>替换后的新字符串。</returns>
        public static string Replace(this string @this, int startIndex, int length, string value)
        {
            @this = @this.Remove(startIndex, length).Insert(startIndex, value);

            return @this;
        }
    }
}
