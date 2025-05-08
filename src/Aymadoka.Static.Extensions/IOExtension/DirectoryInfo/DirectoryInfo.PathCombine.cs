using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension;

public static partial class DirectoryInfoExtensions
{
    public static string PathCombine(this DirectoryInfo @this, params string[] paths)
    {
        List<string> list = paths.ToList();
        list.Insert(0, @this.FullName);
        return Path.Combine(list.ToArray());
    }
}
