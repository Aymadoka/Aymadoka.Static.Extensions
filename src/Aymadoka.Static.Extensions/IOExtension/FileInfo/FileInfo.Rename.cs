using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension;

public static partial class FileInfoExtensions
{
    public static void Rename(this FileInfo @this, string newName)
    {
        string filePath = Path.Combine(@this.Directory.FullName, newName);
        @this.MoveTo(filePath);
    }
}
