using System.Web;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static string JavaScriptStringEncode(this string value)
        {
            return HttpUtility.JavaScriptStringEncode(value);
        }

        public static string JavaScriptStringEncode(this string value, bool addDoubleQuotes)
        {
            return HttpUtility.JavaScriptStringEncode(value, addDoubleQuotes);
        }
    }
}
