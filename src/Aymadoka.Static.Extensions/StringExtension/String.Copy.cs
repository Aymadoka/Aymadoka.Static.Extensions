using System;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string? Copy(this string? str)
    {
        if (str == null)
        {
            return null;
        }

        return new string(str.ToCharArray());
    }
}
