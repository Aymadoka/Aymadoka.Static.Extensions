using System.Collections.Generic;
using System.Text;
using System;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string Concatenate(this IEnumerable<string> @this)
    {
        var sb = new StringBuilder();

        foreach (var s in @this)
        {
            sb.Append(s);
        }

        return sb.ToString();
    }

    public static string Concatenate<T>(this IEnumerable<T> source, Func<T, string> func)
    {
        var sb = new StringBuilder();
        foreach (var item in source)
        {
            sb.Append(func(item));
        }

        return sb.ToString();
    }
}
