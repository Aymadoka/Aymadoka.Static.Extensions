using System;

namespace Aymadoka.Static.CharExtension;

public static partial class CharExtensions
{
    public static bool IsLetter(this char c)
    {
        return char.IsLetter(c);
    }
}
