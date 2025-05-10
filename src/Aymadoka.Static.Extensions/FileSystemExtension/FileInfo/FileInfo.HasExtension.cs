using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
