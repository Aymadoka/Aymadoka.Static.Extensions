using System.Web;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 对字符串进行 JavaScript 字符串编码。
        /// </summary>
        /// <param name="value">要编码的字符串。</param>
        /// <returns>编码后的字符串。</returns>
        public static string JavaScriptStringEncode(this string value)
        {
            return HttpUtility.JavaScriptStringEncode(value);
        }

        /// <summary>
        /// 对字符串进行 JavaScript 字符串编码，并可选择是否添加双引号。
        /// </summary>
        /// <param name="value">要编码的字符串。</param>
        /// <param name="addDoubleQuotes">是否在编码结果外部添加双引号。</param>
        /// <returns>编码后的字符串。</returns>
        public static string JavaScriptStringEncode(this string value, bool addDoubleQuotes)
        {
            return HttpUtility.JavaScriptStringEncode(value, addDoubleQuotes);
        }
    }
}
