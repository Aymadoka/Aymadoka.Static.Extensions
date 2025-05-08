using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension;

public static partial class FileInfoExtensions
{
    public static IEnumerable<String> ReadLines(this FileInfo @this)
    {
        return File.ReadLines(@this.FullName);
    }

    public static IEnumerable<String> ReadLines(this FileInfo @this, Encoding encoding)
    {
        return File.ReadLines(@this.FullName, encoding);
    }
}
