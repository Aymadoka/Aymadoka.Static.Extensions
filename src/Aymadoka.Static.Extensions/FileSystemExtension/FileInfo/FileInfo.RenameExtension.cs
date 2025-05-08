using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension;

public static partial class FileInfoExtensions
{
    public static void RenameExtension(this FileInfo @this, String extension)
    {
        string filePath = Path.ChangeExtension(@this.FullName, extension);
        @this.MoveTo(filePath);
    }
}
