using System;
using System.Collections;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        public static int BinarySearch<T>(this T[] array, T value)
        {
            return Array.BinarySearch(array, value);
        }

        public static int BinarySearch<T>(this T[] array, int index, int length, T value)
        {
            return Array.BinarySearch(array, index, length, value);
        }

        public static int BinarySearch<T>(this T[] array, T value, IComparer comparer)
        {
            return Array.BinarySearch(array, value, comparer);
        }

        public static int BinarySearch<T>(this T[] array, int index, int length, T value, IComparer comparer)
        {
            return Array.BinarySearch(array, index, length, value, comparer);
        }
    }
}
