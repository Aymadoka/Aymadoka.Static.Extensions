using System;
using System.Collections.Generic;
using System.IO;

namespace Aymadoka.Static.DirectoryInfoExtension;

public static partial class DirectoryInfoExtensions
{
    public static void Delete(this IEnumerable<DirectoryInfo> @this)
    {
        foreach (DirectoryInfo t in @this)
        {
            t.Delete();
        }
    }
}
