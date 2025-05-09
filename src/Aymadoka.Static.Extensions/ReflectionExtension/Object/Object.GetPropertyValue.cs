using System;
using System.Reflection;

namespace Aymadoka.Static.ReflectionExtension;

public static partial class ObjectExtensions
{
    public static object GetPropertyValue<T>(this T @this, string propertyName)
    {
        Type type = @this.GetType();
        PropertyInfo property = type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

        return property.GetValue(@this, null);
    }
}
