using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static void SetByte(this Array array, int index, byte value)
    {
        Buffer.SetByte(array, index, value);
    }
}
