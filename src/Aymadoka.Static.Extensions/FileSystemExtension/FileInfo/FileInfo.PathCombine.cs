using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public static partial class FileInfoExtensions
    {
        public static string PathCombine(this IEnumerable<string> @this)
        {
            return Path.Combine(@this.ToArray());
        }
    }
}
