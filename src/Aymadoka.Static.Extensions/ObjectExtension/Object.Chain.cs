using System;

namespace Aymadoka.Static.ObjectExtension;

public static partial class ObjectExtensions
{
    public static T Chain<T>(this T @this, Action<T> action)
    {
        action(@this);

        return @this;
    }
}
