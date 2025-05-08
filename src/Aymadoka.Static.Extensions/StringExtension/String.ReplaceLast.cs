using System.Collections.Generic;
using System.Linq;
using System;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string ReplaceLast(this string @this, string oldValue, string newValue)
    {
        int startindex = @this.LastIndexOf(oldValue);

        if (startindex == -1)
        {
            return @this;
        }

        return @this.Remove(startindex, oldValue.Length).Insert(startindex, newValue);
    }

    public static string ReplaceLast(this string @this, int number, string oldValue, string newValue)
    {
        List<string> list = @this.Split(oldValue).ToList();
        int old = Math.Max(0, list.Count - number - 1);
        IEnumerable<string> listStart = list.Take(old);
        IEnumerable<string> listEnd = list.Skip(old);

        return string.Join(oldValue, listStart) +
               (old > 0 ? oldValue : "") +
               string.Join(newValue, listEnd);
    }
}
