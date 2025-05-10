using System;

namespace Aymadoka.Static.CharExtension
{
    public static partial class CharExtensions
    {
        public static bool IsControl(this char c)
        {
            return char.IsControl(c);
        }
    }
}
