namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 如果字符串为空（""），则返回指定的默认值；否则返回原字符串。
        /// </summary>
        /// <param name="this">要检查的字符串。</param>
        /// <param name="defaultValue">当字符串为空时返回的默认值。</param>
        /// <returns>原字符串或默认值。</returns>
        public static string IfEmpty(this string @this, string defaultValue)
        {
            if (@this.IsEmpty())
            {
                return defaultValue;
            }

            return @this;
        }
    }
}
