using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.StringExtension;

public static partial class StringExtensions
{
    public static string PathCombine(this string @this, params string[] paths)
    {
        List<string> list = paths.ToList();
        list.Insert(0, @this);
        return Path.Combine(list.ToArray());
    }
}
