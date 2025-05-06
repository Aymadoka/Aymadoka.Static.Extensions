using System;
using System.Collections;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static void Sort<T>(this T[] array)
    {
        Array.Sort(array);
    }

    public static void Sort<T>(this T[] array, T[] items)
    {
        Array.Sort(array, items);
    }

    public static void Sort<T>(this T[] array, int index, int length)
    {
        Array.Sort(array, index, length);
    }

    public static void Sort<T>(this T[] array, T[] items, int index, int length)
    {
        Array.Sort(array, items, index, length);
    }

    public static void Sort<T>(this T[] array, IComparer comparer)
    {
        Array.Sort(array, comparer);
    }

    public static void Sort<T>(this T[] array, T[] items, IComparer comparer)
    {
        Array.Sort(array, items, comparer);
    }

    public static void Sort<T>(this T[] array, int index, int length, IComparer comparer)
    {
        Array.Sort(array, index, length, comparer);
    }

    public static void Sort<T>(this T[] array, T[] items, int index, int length, IComparer comparer)
    {
        Array.Sort(array, items, index, length, comparer);
    }
}
