using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        public static void WriteAllLines(this FileInfo @this, String[] contents)
        {
            File.WriteAllLines(@this.FullName, contents);
        }

        public static void WriteAllLines(this FileInfo @this, String[] contents, Encoding encoding)
        {
            File.WriteAllLines(@this.FullName, contents, encoding);
        }

        public static void WriteAllLines(this FileInfo @this, IEnumerable<String> contents)
        {
            File.WriteAllLines(@this.FullName, contents);
        }

        public static void WriteAllLines(this FileInfo @this, IEnumerable<String> contents, Encoding encoding)
        {
            File.WriteAllLines(@this.FullName, contents, encoding);
        }
    }
}
