using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension;

public static partial class FileInfoExtensions
{
    public static String ReadAllText(this FileInfo @this)
    {
        return File.ReadAllText(@this.FullName);
    }

    public static String ReadAllText(this FileInfo @this, Encoding encoding)
    {
        return File.ReadAllText(@this.FullName, encoding);
    }
}
