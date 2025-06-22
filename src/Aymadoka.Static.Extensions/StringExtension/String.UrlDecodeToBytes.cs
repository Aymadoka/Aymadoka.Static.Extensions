using System.Text;
using System.Web;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将 URL 编码的字符串解码为字节数组，使用默认编码。
        /// </summary>
        /// <param name="str">要解码的 URL 编码字符串。</param>
        /// <returns>解码后的字节数组。</returns>
        public static byte[] UrlDecodeToBytes(this string str)
        {
            var result = HttpUtility.UrlDecodeToBytes(str);
            return result;
        }

        /// <summary>
        /// 将 URL 编码的字符串解码为字节数组，使用指定的编码。
        /// </summary>
        /// <param name="str">要解码的 URL 编码字符串。</param>
        /// <param name="e">用于解码的编码。</param>
        /// <returns>解码后的字节数组。</returns>
        public static byte[] UrlDecodeToBytes(this string str, Encoding e)
        {
            return HttpUtility.UrlDecodeToBytes(str, e);
        }
    }
}
