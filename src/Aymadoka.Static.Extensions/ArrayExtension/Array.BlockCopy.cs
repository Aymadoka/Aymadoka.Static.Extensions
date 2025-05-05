using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static void BlockCopy(this Array src, int srcOffset, Array dst, int dstOffset, int count)
    {
        Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
    }
}
