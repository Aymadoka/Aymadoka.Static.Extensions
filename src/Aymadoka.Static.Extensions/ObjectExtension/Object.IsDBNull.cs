using System;

namespace Aymadoka.Static.ObjectExtension;

public static partial class ObjectExtensions
{
    public static bool IsDBNull<T>(this T value) where T : class
    {
        return Convert.IsDBNull(value);
    }
}
