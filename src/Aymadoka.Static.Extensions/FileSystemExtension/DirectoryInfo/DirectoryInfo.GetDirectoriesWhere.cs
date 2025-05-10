using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this, Func<DirectoryInfo, bool> predicate)
        {
            return Directory.EnumerateDirectories(@this.FullName).Select(x => new DirectoryInfo(x)).Where(x => predicate(x)).ToArray();
        }

        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this, String searchPattern, Func<DirectoryInfo, bool> predicate)
        {
            return Directory.EnumerateDirectories(@this.FullName, searchPattern).Select(x => new DirectoryInfo(x)).Where(x => predicate(x)).ToArray();
        }

        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this, String searchPattern, SearchOption searchOption, Func<DirectoryInfo, bool> predicate)
        {
            return Directory.EnumerateDirectories(@this.FullName, searchPattern, searchOption).Select(x => new DirectoryInfo(x)).Where(x => predicate(x)).ToArray();
        }

        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this, String[] searchPatterns, Func<DirectoryInfo, bool> predicate)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x)).Distinct().Where(x => predicate(x)).ToArray();
        }

        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this, String[] searchPatterns, SearchOption searchOption, Func<DirectoryInfo, bool> predicate)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x, searchOption)).Distinct().Where(x => predicate(x)).ToArray();
        }
    }
}
