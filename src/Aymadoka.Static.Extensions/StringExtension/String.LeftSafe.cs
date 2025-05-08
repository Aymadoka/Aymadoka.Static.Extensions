using System;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string LeftSafe(this string @this, int length)
    {
        return @this.Substring(0, Math.Min(length, @this.Length));
    }
}
