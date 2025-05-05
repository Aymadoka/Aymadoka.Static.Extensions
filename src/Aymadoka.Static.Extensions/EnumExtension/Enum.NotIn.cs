using System;

namespace Aymadoka.Static.EnumExtension
{
    public static partial class EnumExtensions
    {
        public static bool NotIn(this Enum @this, params Enum[] values)
        {
            return Array.IndexOf(values, @this) == -1;
        }
    }
}
