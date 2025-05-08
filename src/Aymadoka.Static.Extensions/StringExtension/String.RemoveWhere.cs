using System.Linq;
using System;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string RemoveWhere(this string @this, Func<char, bool> predicate)
    {
        return new string(@this.ToCharArray().Where(x => !predicate(x)).ToArray());
    }
}
