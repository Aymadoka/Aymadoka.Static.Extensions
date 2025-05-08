using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension;

public static partial class FileInfoExtensions
{
    public static void WriteAllText(this FileInfo @this, String contents)
    {
        File.WriteAllText(@this.FullName, contents);
    }

    public static void WriteAllText(this FileInfo @this, String contents, Encoding encoding)
    {
        File.WriteAllText(@this.FullName, contents, encoding);
    }
}
