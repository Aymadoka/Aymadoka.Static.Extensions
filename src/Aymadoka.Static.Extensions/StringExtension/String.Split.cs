using System;
using System.IO;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string[] Split(this string @this, string separator, StringSplitOptions option = StringSplitOptions.None)
    {
        return @this.Split(new[] { separator }, option);
    }
}
