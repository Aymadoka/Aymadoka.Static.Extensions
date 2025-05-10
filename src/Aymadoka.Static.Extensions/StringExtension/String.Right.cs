namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>获取字符串右侧指定长度的子字符串</summary>
        /// <param name="this">要处理的字符串</param>
        /// <param name="length">要获取的子字符串长度</param>
        /// <returns>右侧指定长度的子字符串；如果输入为 null 或长度无效，则返回空字符串</returns>
        public static string Right(this string @this, int length)
        {
            if (@this.IsNullOrEmpty() || length <= 0)
            {
                return string.Empty;
            }

            return @this.Length <= length ? @this : @this.Substring(@this.Length - length);
        }
    }
}
