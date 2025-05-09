using System;

namespace Aymadoka.Static.ReflectionExtension;

public static partial class ObjectExtensions
{
    public static bool IsSubclassOf<T>(this T @this, Type type)
    {
        return @this.GetType().IsSubclassOf(type);
    }
}
