using System.IO;
using System.Web;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string HtmlAttributeEncode(this string s)
    {
        return HttpUtility.HtmlAttributeEncode(s);
    }

    public static void HtmlAttributeEncode(this string s, TextWriter output)
    {
        HttpUtility.HtmlAttributeEncode(s, output);
    }
}
