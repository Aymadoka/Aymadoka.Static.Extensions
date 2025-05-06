using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static byte[] Resize(this byte[] @this, int newSize)
    {
        Array.Resize(ref @this, newSize);
        return @this;
    }
}
