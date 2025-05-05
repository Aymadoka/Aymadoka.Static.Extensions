using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static int ByteLength(this Array array)
    {
        return Buffer.ByteLength(array);
    }
}
