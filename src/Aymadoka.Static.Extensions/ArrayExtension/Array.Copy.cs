using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static void Copy(this Array sourceArray, Array destinationArray, int length)
    {
        Array.Copy(sourceArray, destinationArray, length);
    }

    public static void Copy(this Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
    {
        Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
    }

    public static void Copy(this Array sourceArray, Array destinationArray, Int64 length)
    {
        Array.Copy(sourceArray, destinationArray, length);
    }

    public static void Copy(this Array sourceArray, Int64 sourceIndex, Array destinationArray, Int64 destinationIndex, Int64 length)
    {
        Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
    }
}
