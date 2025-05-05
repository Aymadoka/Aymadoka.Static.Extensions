using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static void Clear(this Array array, int index, int length)
    {
        Array.Clear(array, index, length);
    }
}
