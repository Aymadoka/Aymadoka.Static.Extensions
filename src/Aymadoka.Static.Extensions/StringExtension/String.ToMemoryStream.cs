using System.IO;
using System.Text;
using System;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static Stream ToMemoryStream(this string @this)
    {
        Encoding encoding = Activator.CreateInstance<ASCIIEncoding>();
        return new MemoryStream(encoding.GetBytes(@this));
    }
}
