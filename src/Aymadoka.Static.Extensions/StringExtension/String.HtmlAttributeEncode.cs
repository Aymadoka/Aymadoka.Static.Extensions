using System.IO;
using System.Web;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 对字符串进行 HTML 属性编码。
        /// </summary>
        /// <param name="s">要编码的字符串。</param>
        /// <returns>编码后的字符串。</returns>
        public static string HtmlAttributeEncode(this string s)
        {
            return HttpUtility.HtmlAttributeEncode(s);
        }

        /// <summary>
        /// 对字符串进行 HTML 属性编码，并将结果写入指定的 <see cref="TextWriter"/>。
        /// </summary>
        /// <param name="s">要编码的字符串。</param>
        /// <param name="output">用于接收编码结果的 <see cref="TextWriter"/> 实例。</param>
        public static void HtmlAttributeEncode(this string s, TextWriter output)
        {
            HttpUtility.HtmlAttributeEncode(s, output);
        }
    }
}
