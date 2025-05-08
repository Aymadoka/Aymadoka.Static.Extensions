using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension;

public static partial class FileInfoExtensions
{
    public static String GetDirectoryName(this FileInfo @this)
    {
        return @this.Directory.Name;
    }
}
