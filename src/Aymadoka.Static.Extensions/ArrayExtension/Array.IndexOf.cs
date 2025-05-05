using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static int IndexOf<T>(this Array @this, T value)
    {
        return Array.IndexOf(@this, value);
    }

    public static int IndexOf<T>(this Array array, T value, int startIndex)
    {
        return Array.IndexOf(array, value, startIndex);
    }

    public static int IndexOf<T>(this Array array, T value, int startIndex, int count)
    {
        return Array.IndexOf(array, value, startIndex, count);
    }
}
