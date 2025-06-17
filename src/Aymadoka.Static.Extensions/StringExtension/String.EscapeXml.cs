namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 对字符串中的特殊 XML 字符进行转义。
        /// 将 &amp;、&lt;、&gt;、&quot;、&apos; 分别替换为 &amp;amp;、&amp;lt;、&amp;gt;、&amp;quot;、&amp;apos;。
        /// </summary>
        /// <param name="this">要转义的字符串。</param>
        /// <returns>转义后的 XML 字符串。</returns>
        public static string EscapeXml(this string @this)
        {
            var result = @this
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("\"", "&quot;")
                .Replace("'", "&apos;");

            return result;
        }
    }
}
