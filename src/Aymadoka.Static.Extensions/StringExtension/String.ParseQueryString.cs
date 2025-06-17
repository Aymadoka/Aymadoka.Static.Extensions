using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 解析查询字符串为 <see cref="NameValueCollection"/>。
        /// </summary>
        /// <param name="query">要解析的查询字符串。</param>
        /// <returns>包含查询参数的 <see cref="NameValueCollection"/>。</returns>
        public static NameValueCollection ParseQueryString(this string query)
        {
            return HttpUtility.ParseQueryString(query);
        }

        /// <summary>
        /// 使用指定编码解析查询字符串为 <see cref="NameValueCollection"/>。
        /// </summary>
        /// <param name="query">要解析的查询字符串。</param>
        /// <param name="encoding">用于解码的编码。</param>
        /// <returns>包含查询参数的 <see cref="NameValueCollection"/>。</returns>
        public static NameValueCollection ParseQueryString(this string query, Encoding encoding)
        {
            return HttpUtility.ParseQueryString(query, encoding);
        }
    }
}
