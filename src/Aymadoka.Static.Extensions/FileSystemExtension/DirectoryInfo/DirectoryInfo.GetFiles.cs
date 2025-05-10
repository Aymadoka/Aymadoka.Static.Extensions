using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        public static FileInfo[] GetFiles(this DirectoryInfo @this, String[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x)).Distinct().ToArray();
        }

        public static FileInfo[] GetFiles(this DirectoryInfo @this, String[] searchPatterns, SearchOption searchOption)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x, searchOption)).Distinct().ToArray();
        }
    }
}
