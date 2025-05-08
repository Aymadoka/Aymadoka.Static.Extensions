using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension;

public static partial class FileInfoExtensions
{
    public static void AppendAllLines(this FileInfo @this, IEnumerable<String> contents)
    {
        File.AppendAllLines(@this.FullName, contents);
    }

    public static void AppendAllLines(this FileInfo @this, IEnumerable<String> contents, Encoding encoding)
    {
        File.AppendAllLines(@this.FullName, contents, encoding);
    }
}
