using System;
using System.IO;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        public static void WriteAllBytes(this FileInfo @this, Byte[] bytes)
        {
            File.WriteAllBytes(@this.FullName, bytes);
        }
    }
}
