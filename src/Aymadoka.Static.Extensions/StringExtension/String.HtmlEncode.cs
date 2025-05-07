using System.IO;
using System.Web;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string HtmlEncode(this string s)
    {
        return HttpUtility.HtmlEncode(s);
    }

    public static void HtmlEncode(this string s, TextWriter output)
    {
        HttpUtility.HtmlEncode(s, output);
    }
}
