using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        public static String GetDirectoryFullName(this FileInfo @this)
        {
            return @this.Directory.FullName;
        }
    }
}
