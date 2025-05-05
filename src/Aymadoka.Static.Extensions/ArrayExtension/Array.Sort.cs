using System;
using System.Collections;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static void Sort(this Array array)
    {
        Array.Sort(array);
    }

    public static void Sort(this Array array, Array items)
    {
        Array.Sort(array, items);
    }

    public static void Sort(this Array array, int index, int length)
    {
        Array.Sort(array, index, length);
    }

    public static void Sort(this Array array, Array items, int index, int length)
    {
        Array.Sort(array, items, index, length);
    }

    public static void Sort(this Array array, IComparer comparer)
    {
        Array.Sort(array, comparer);
    }

    public static void Sort(this Array array, Array items, IComparer comparer)
    {
        Array.Sort(array, items, comparer);
    }

    public static void Sort(this Array array, int index, int length, IComparer comparer)
    {
        Array.Sort(array, index, length, comparer);
    }

    public static void Sort(this Array array, Array items, int index, int length, IComparer comparer)
    {
        Array.Sort(array, items, index, length, comparer);
    }
}
