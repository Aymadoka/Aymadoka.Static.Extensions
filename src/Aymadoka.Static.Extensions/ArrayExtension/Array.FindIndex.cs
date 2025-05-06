using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static int FindIndex<T>(this T[] array, Predicate<T> match)
    {
        return Array.FindIndex(array, match);
    }

    public static int FindIndex<T>(this T[] array, int startIndex, Predicate<T> match)
    {
        return Array.FindIndex(array, startIndex, match);
    }

    public static int FindIndex<T>(this T[] array, int startIndex, int count, Predicate<T> match)
    {
        return Array.FindIndex(array, startIndex, count, match);
    }
}
