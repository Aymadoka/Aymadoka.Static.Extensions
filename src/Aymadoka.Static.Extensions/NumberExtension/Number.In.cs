using System;
using System.Numerics;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        public static bool In<T>(this T @this, params T[] values) where T : struct, INumber<T>
        {
            return Array.IndexOf(values, @this) != -1;
        }
    }
}
