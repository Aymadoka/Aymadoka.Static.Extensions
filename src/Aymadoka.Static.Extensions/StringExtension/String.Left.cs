namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>获取字符串左侧指定长度的子字符串</summary>
        /// <param name="value">要处理的字符串</param>
        /// <param name="length">要获取的子字符串长度</param>
        /// <returns>左侧指定长度的子字符串；如果输入为 null 或长度无效，则返回空字符串</returns>
        public static string? Left(this string? value, int length)
        {
            if (value.IsNullOrEmpty() || length <= 0)
            {
                return string.Empty;
            }

            return value.Length <= length ? value : value.Substring(0, length);
        }
    }
}
