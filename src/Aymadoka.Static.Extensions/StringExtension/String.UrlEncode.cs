using System.Text;
using System.Web;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 对字符串进行 URL 编码。
        /// </summary>
        /// <param name="str">要编码的字符串。</param>
        /// <returns>URL 编码后的字符串。</returns>
        public static string UrlEncode(this string str)
        {
            return HttpUtility.UrlEncode(str);
        }

        /// <summary>
        /// 使用指定的编码对字符串进行 URL 编码。
        /// </summary>
        /// <param name="str">要编码的字符串。</param>
        /// <param name="e">用于编码的 <see cref="Encoding"/>。</param>
        /// <returns>URL 编码后的字符串。</returns>
        public static string UrlEncode(this string str, Encoding e)
        {
            return HttpUtility.UrlEncode(str, e);
        }
    }
}
