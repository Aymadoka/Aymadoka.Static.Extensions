using System;

namespace Aymadoka.Static.ObjectExtension;

public static partial class ObjectExtensions
{
    public static TResult? GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return default;
        }
    }

    public static TResult? GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func, TResult? defaultValue)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    public static TResult? GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func, Func<TResult?> defaultValueFactory)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    public static TResult? GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func, Func<T, TResult?> defaultValueFactory)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory(@this);
        }
    }
}
