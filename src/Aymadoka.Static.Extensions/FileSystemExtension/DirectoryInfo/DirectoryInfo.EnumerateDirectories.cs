using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        public static IEnumerable<DirectoryInfo> EnumerateDirectories(this DirectoryInfo @this)
        {
            return Directory.EnumerateDirectories(@this.FullName).Select(x => new DirectoryInfo(x));
        }

        public static IEnumerable<DirectoryInfo> EnumerateDirectories(this DirectoryInfo @this, string searchPattern)
        {
            return Directory.EnumerateDirectories(@this.FullName, searchPattern).Select(x => new DirectoryInfo(x));
        }

        public static IEnumerable<DirectoryInfo> EnumerateDirectories(this DirectoryInfo @this, string searchPattern, SearchOption searchOption)
        {
            return Directory.EnumerateDirectories(@this.FullName, searchPattern, searchOption).Select(x => new DirectoryInfo(x));
        }

        public static IEnumerable<DirectoryInfo> EnumerateDirectories(this DirectoryInfo @this, string[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x)).Distinct();
        }

        public static IEnumerable<DirectoryInfo> EnumerateDirectories(this DirectoryInfo @this, string[] searchPatterns, SearchOption searchOption)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x, searchOption)).Distinct();
        }
    }
}
