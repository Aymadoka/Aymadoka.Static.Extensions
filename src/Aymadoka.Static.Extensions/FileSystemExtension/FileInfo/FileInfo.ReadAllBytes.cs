using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        public static Byte[] ReadAllBytes(this FileInfo @this)
        {
            return File.ReadAllBytes(@this.FullName);
        }
    }
}
