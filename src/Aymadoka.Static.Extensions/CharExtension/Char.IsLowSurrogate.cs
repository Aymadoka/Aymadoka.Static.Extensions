using System;

namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        public static bool IsLowSurrogate(this char c)
        {
            return char.IsLowSurrogate(c);
        }
    }
}
