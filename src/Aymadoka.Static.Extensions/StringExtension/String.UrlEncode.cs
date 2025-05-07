using System.Text;
using System.Web;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string UrlEncode(this string str)
    {
        return HttpUtility.UrlEncode(str);
    }

    public static string UrlEncode(this string str, Encoding e)
    {
        return HttpUtility.UrlEncode(str, e);
    }
}
