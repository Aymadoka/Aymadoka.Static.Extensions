using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        public static Boolean HasExtension(this FileInfo @this)
        {
            return Path.HasExtension(@this.FullName);
        }
    }
}
