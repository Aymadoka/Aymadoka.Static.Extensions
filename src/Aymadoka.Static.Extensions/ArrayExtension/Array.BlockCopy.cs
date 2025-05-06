using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static void BlockCopy<T>(this T[] src, int srcOffset, T[] dst, int dstOffset, int count)
    {
        Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
    }
}
