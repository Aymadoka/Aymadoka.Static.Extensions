using System;
using System.Reflection;

namespace Aymadoka.Static.ReflectionExtension;

public static partial class ObjectExtensions
{
    public static bool IsAttributeDefined(this object @this, Type attributeType, bool inherit)
    {
        return @this.GetType().IsDefined(attributeType, inherit);
    }

    /// <summary>
    ///     An object extension method that query if '@this' is attribute defined.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="inherit">true to inherit.</param>
    /// <returns>true if attribute defined, false if not.</returns>
    public static bool IsAttributeDefined<T>(this object @this, bool inherit) where T : Attribute
    {
        return @this.GetType().IsDefined(typeof(T), inherit);
    }
}
