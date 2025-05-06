using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static int LastIndexOf<T>(this T[] array, T value)
    {
        return Array.LastIndexOf(array, value);
    }

    public static int LastIndexOf<T>(this T[] array, T value, int startIndex)
    {
        return Array.LastIndexOf(array, value, startIndex);
    }

    public static int LastIndexOf<T>(this T[] array, T value, int startIndex, int count)
    {
        return Array.LastIndexOf(array, value, startIndex, count);
    }
}
