using System;

namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        public static void IfNotNull<T>(this T @this, Action<T> action) where T : class
        {
            if (@this != null)
            {
                action(@this);
            }
        }

        public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func) where T : class
        {
            if (@this != null)
            {
                return func(@this);
            }

            return default;
        }

        public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func, TResult defaultValue) where T : class
        {
            if (@this != null)
            {
                return func(@this);
            }

            return defaultValue;
        }

        public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func, Func<TResult> defaultValueFactory) where T : class
        {
            if (@this != null)
            {
                return func(@this);
            }

            return defaultValueFactory();
        }
    }
}
