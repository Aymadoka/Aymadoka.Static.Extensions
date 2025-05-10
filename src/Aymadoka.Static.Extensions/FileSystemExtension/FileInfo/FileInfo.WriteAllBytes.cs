using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
