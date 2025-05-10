using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        public static String ChangeExtension(this FileInfo @this, String extension)
        {
            return Path.ChangeExtension(@this.FullName, extension);
        }
    }
}
