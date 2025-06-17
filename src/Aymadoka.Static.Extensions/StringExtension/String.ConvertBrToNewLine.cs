namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将字符串中的 &lt;br /&gt; 和 &lt;br&gt; 标签替换为换行符（\r\n）。
        /// </summary>
        /// <param name="this">要处理的字符串。</param>
        /// <returns>替换后的字符串。</returns>
        public static string ConvertBrToNewLine(this string @this)
        {
            return @this.Replace("<br />", "\r\n").Replace("<br>", "\r\n");
        }
    }
}
