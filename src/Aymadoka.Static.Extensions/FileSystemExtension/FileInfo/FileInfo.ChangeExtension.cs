using System;
using System.IO;

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
