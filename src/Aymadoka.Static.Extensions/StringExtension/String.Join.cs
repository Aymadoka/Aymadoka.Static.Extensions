using System.Collections.Generic;
using System;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string Join(this string separator, string[] value)
    {
        return string.Join(separator, value);
    }

    public static string Join(this string separator, object[] values)
    {
        return string.Join(separator, values);
    }

    public static string Join<T>(this string separator, IEnumerable<T> values)
    {
        return string.Join(separator, values);
    }

    public static string Join(this string separator, IEnumerable<string> values)
    {
        return string.Join(separator, values);
    }

    public static string Join(this string separator, string[] value, int startIndex, int count)
    {
        return string.Join(separator, value, startIndex, count);
    }
}
