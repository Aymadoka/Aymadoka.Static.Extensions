using System;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static void Copy<T>(this T[] sourceArray, T[] destinationArray, int length)
    {
        Array.Copy(sourceArray, destinationArray, length);
    }

    public static void Copy<T>(this T[] sourceArray, int sourceIndex, T[] destinationArray, int destinationIndex, int length)
    {
        Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
    }

    public static void Copy<T>(this T[] sourceArray, T[] destinationArray, Int64 length)
    {
        Array.Copy(sourceArray, destinationArray, length);
    }

    public static void Copy<T>(this T[] sourceArray, Int64 sourceIndex, T[] destinationArray, Int64 destinationIndex, Int64 length)
    {
        Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
    }
}
