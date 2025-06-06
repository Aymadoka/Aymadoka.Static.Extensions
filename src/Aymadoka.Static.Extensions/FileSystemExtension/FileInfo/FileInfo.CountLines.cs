using System;
using System.IO;
using System.Linq;

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
