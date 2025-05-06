using System.Globalization;
using System;

namespace Aymadoka.Static.CharExtension;

public static partial class CharExtensions
{
    public static bool IsWhiteSpace(this char c)
    {
        return char.IsWhiteSpace(c);
    }
}
