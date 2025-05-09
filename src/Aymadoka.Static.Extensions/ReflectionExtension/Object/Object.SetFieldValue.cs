using System;
using System.Reflection;

namespace Aymadoka.Static.ReflectionExtension;

public static partial class ObjectExtensions
{
    public static void SetFieldValue<T>(this T @this, string fieldName, object value)
    {
        Type type = @this.GetType();
        FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        field.SetValue(@this, value);
    }
}
