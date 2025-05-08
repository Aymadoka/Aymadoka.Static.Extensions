using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension;

public static partial class FileInfoExtensions
{
    public static IEnumerable<FileInfo> ForEach(this IEnumerable<FileInfo> @this, Action<FileInfo> action)
    {
        foreach (FileInfo t in @this)
        {
            action(t);
        }
        return @this;
    }
}
