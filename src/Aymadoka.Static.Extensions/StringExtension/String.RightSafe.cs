using System;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string RightSafe(this string @this, int length)
    {
        return @this.Substring(Math.Max(0, @this.Length - length));
    }
}
