using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        public static String GetPathRoot(this FileInfo @this)
        {
            return Path.GetPathRoot(@this.FullName);
        }
    }
}
