using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        public static int CountLines(this FileInfo @this)
        {
            return File.ReadAllLines(@this.FullName).Length;
        }

        public static int CountLines(this FileInfo @this, Func<string, bool> predicate)
        {
            return File.ReadAllLines(@this.FullName).Count(predicate);
        }
    }
}
