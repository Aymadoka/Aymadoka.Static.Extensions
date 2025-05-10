using System;
using System.Reflection;

namespace Aymadoka.Static.ReflectionExtension
{
    public static partial class ObjectExtensions
    {
        public static object GetFieldValue<T>(this T @this, string fieldName)
        {
            Type type = @this.GetType();
            FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

            return field.GetValue(@this);
        }
    }
}
