namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 如果字符串为空字符串（""）则返回 null，否则返回原字符串。
        /// </summary>
        /// <param name="this">要检查的字符串。</param>
        /// <returns>如果字符串为空则为 null，否则为原字符串。</returns>
        public static string? NullIfEmpty(this string? @this)
        {
            if (@this.IsEmpty())
            {
                return null;
            }

            return @this;
        }
    }
}
