using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static bool TrueForAll<T>(this T[] array, Predicate<T> match)
    {
        return Array.TrueForAll(array, match);
    }
}
