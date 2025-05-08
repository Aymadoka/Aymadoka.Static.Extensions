using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension;

public static partial class DirectoryInfoExtensions
{
    public static FileInfo PathCombineFile(this DirectoryInfo @this, params string[] paths)
    {
        List<string> list = paths.ToList();
        list.Insert(0, @this.FullName);
        return new FileInfo(Path.Combine(list.ToArray()));
    }
}
