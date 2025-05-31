using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        public static Boolean IsPathRooted(this FileInfo @this)
        {
            return Path.IsPathRooted(@this.FullName);
        }
    }
}
