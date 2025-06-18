using System.Text;
using System.Web;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将字符串进行 URL 编码，并返回编码后的字节数组，使用默认编码（UTF-8）。
        /// </summary>
        /// <param name="str">要进行 URL 编码的字符串。</param>
        /// <returns>编码后的字节数组。</returns>
        public static byte[] UrlEncodeToBytes(this string str)
        {
            return HttpUtility.UrlEncodeToBytes(str);
        }

        /// <summary>
        /// 将字符串进行 URL 编码，并返回编码后的字节数组，使用指定的编码。
        /// </summary>
        /// <param name="str">要进行 URL 编码的字符串。</param>
        /// <param name="e">用于编码的字符编码。</param>
        /// <returns>编码后的字节数组。</returns>
        public static byte[] UrlEncodeToBytes(this string str, Encoding e)
        {
            return HttpUtility.UrlEncodeToBytes(str, e);
        }
    }
}
