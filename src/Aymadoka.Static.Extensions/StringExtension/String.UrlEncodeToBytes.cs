using System.Text;
using System.Web;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static byte[] UrlEncodeToBytes(this string str)
    {
        return HttpUtility.UrlEncodeToBytes(str);
    }

    public static byte[] UrlEncodeToBytes(this string str, Encoding e)
    {
        return HttpUtility.UrlEncodeToBytes(str, e);
    }
}
