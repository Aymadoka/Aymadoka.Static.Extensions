using System.IO;
using System.Web;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 对指定字符串进行 HTML 编码。
        /// </summary>
        /// <param name="s">要进行 HTML 编码的字符串。</param>
        /// <returns>HTML 编码后的字符串。</returns>
        public static string HtmlEncode(this string s)
        {
            return HttpUtility.HtmlEncode(s);
        }

        /// <summary>
        /// 对指定字符串进行 HTML 编码，并将结果输出到指定的 <see cref="TextWriter"/>。
        /// </summary>
        /// <param name="s">要进行 HTML 编码的字符串。</param>
        /// <param name="output">用于接收编码结果的 <see cref="TextWriter"/> 实例。</param>
        public static void HtmlEncode(this string s, TextWriter output)
        {
            HttpUtility.HtmlEncode(s, output);
        }
    }
}
