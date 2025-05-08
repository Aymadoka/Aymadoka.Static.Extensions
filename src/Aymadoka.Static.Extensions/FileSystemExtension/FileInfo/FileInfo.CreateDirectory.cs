using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension;

public static partial class FileInfoExtensions
{
    public static DirectoryInfo CreateDirectory(this FileInfo @this)
    {
        return Directory.CreateDirectory(@this.Directory.FullName);
    }
}
