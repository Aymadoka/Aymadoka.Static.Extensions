using System.Text;
using System.Web;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 对 URL 编码的字符串进行解码，使用默认编码方式。
        /// </summary>
        /// <param name="str">要解码的 URL 编码字符串。</param>
        /// <returns>解码后的字符串。</returns>
        public static string UrlDecode(this string str)
        {
            return HttpUtility.UrlDecode(str);
        }

        /// <summary>
        /// 对 URL 编码的字符串进行解码，使用指定的编码方式。
        /// </summary>
        /// <param name="str">要解码的 URL 编码字符串。</param>
        /// <param name="e">用于解码的编码方式。</param>
        /// <returns>解码后的字符串。</returns>
        public static string UrlDecode(this string str, Encoding e)
        {
            return HttpUtility.UrlDecode(str, e);
        }
    }
}
