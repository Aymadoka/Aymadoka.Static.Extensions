using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        public static void Reverse<T>(this T[] array)
        {
            Array.Reverse(array);
        }

        public static void Reverse<T>(this T[] array, int index, int length)
        {
            Array.Reverse(array, index, length);
        }
    }
}
