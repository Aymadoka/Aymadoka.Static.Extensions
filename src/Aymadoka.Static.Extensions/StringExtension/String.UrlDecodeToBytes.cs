using System.Text;
using System.Web;

namespace Aymadoka.Static.StringExtension
{
    public static partial class StringExtensions
    {
        public static byte[] UrlDecodeToBytes(this string str)
        {
            return HttpUtility.UrlDecodeToBytes(str);
        }

        public static byte[] UrlDecodeToBytes(this string str, Encoding e)
        {
            return HttpUtility.UrlDecodeToBytes(str, e);
        }
    }
}
