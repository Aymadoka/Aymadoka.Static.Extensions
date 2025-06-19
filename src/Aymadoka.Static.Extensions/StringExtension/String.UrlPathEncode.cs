using System.Web;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 对字符串进行 URL 路径编码。
        /// </summary>
        /// <param name="str">要编码的字符串。</param>
        /// <returns>编码后的字符串，适用于 URL 路径。</returns>
        public static string UrlPathEncode(this string str)
        {
            var result = HttpUtility.UrlPathEncode(str);
            return result;
        }
    }
}
