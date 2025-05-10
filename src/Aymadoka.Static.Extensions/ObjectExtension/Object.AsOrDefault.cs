using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        public static T AsOrDefault<T>(this object? @this)
        {
            if (@this is T value)
            {
                return value;
            }

            return default(T);
        }

        public static T AsOrDefault<T>(this object? @this, T defaultValue)
        {
            if (@this is T value)
            {
                return value;
            }

            return defaultValue;
        }

        public static T AsOrDefault<T>(this object? @this, Func<T> defaultValueFactory)
        {
            if (@this is T value)
            {
                return value;
            }

            return defaultValueFactory();
        }

        public static T AsOrDefault<T>(this object @this, Func<object, T> defaultValueFactory)
        {
            if (@this is T value)
            {
                return value;
            }

            return defaultValueFactory(@this);
        }
    }
}
