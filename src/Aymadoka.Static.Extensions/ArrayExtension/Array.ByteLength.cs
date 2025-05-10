using System;

namespace Aymadoka.Static.ArrayExtension
{
    public static partial class ArrayExtensions
    {
        public static int ByteLength<T>(this T[] array)
        {
            return Buffer.ByteLength(array);
        }
    }
}
