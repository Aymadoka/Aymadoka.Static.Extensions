using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static byte GetByte(this Array array, int index)
    {
        return Buffer.GetByte(array, index);
    }
}
