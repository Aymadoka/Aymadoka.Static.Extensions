using System.IO;
using System.Web;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 对字符串进行 HTML 解码。
        /// </summary>
        /// <param name="s">要解码的字符串。</param>
        /// <returns>解码后的字符串。</returns>
        public static string HtmlDecode(this string s)
        {
            return HttpUtility.HtmlDecode(s);
        }

        /// <summary>
        /// 对字符串进行 HTML 解码，并将结果写入指定的 <see cref="TextWriter"/>。
        /// </summary>
        /// <param name="s">要解码的字符串。</param>
        /// <param name="output">用于接收解码结果的 <see cref="TextWriter"/> 实例。</param>
        public static void HtmlDecode(this string s, TextWriter output)
        {
            HttpUtility.HtmlDecode(s, output);
        }
    }
}
