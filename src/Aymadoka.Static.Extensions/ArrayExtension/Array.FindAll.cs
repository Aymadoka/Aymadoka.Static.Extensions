using System;
using System.Collections.ObjectModel;

namespace Aymadoka.Static.ArrayExtension;

public static partial class ArrayExtensions
{
    public static T[] FindAll<T>(this T[] array, Predicate<T> match)
    {
        return Array.FindAll(array, match);
    }
}
