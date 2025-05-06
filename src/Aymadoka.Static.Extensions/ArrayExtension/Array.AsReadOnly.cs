using System;
using System.Collections.ObjectModel;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static ReadOnlyCollection<T> AsReadOnly<T>(this T[] array)
    {
        return Array.AsReadOnly(array);
    }
}
