using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        public static void AppendAllText(this FileInfo @this, String contents)
        {
            File.AppendAllText(@this.FullName, contents);
        }

        public static void AppendAllText(this FileInfo @this, String contents, Encoding encoding)
        {
            File.AppendAllText(@this.FullName, contents, encoding);
        }
    }
}
