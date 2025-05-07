using System;

namespace Aymadoka.Static.ObjectExtension;

public static partial class ObjectExtensions
{
    public static bool NotIn<T>(this T @this, params T[] values)
    {
        return Array.IndexOf(values, @this) == -1;
    }
}
