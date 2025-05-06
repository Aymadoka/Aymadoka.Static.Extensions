using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static bool In<T>(this T @this, params T[] values)
    {
        return Array.IndexOf(values, @this) != -1;
    }
}
