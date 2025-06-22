namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将字符串中的所有换行符（\r\n 或 \n）替换为 &lt;br /&gt;。
        /// </summary>
        /// <param name="this">要处理的字符串。</param>
        /// <returns>替换后的字符串。</returns>
        public static string Nl2Br(this string @this)
        {
            return @this.Replace("\r\n", "<br />").Replace("\n", "<br />");
        }
    }
}
