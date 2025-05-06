using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static byte GetByte<T>(this T[] array, int index)
    {
        return Buffer.GetByte(array, index);
    }
}
