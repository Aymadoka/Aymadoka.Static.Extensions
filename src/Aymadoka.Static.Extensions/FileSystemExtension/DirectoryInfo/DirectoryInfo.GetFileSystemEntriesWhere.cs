using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        public static string[] GetFileSystemEntriesWhere(this DirectoryInfo @this, Func<string, bool> predicate)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName).Where(x => predicate(x)).ToArray();
        }

        public static string[] GetFileSystemEntriesWhere(this DirectoryInfo @this, String searchPattern, Func<string, bool> predicate)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName, searchPattern).Where(x => predicate(x)).ToArray();
        }

        public static string[] GetFileSystemEntriesWhere(this DirectoryInfo @this, String searchPattern, SearchOption searchOption, Func<string, bool> predicate)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName, searchPattern, searchOption).Where(x => predicate(x)).ToArray();
        }

        public static string[] GetFileSystemEntriesWhere(this DirectoryInfo @this, String[] searchPatterns, Func<string, bool> predicate)
        {
            return searchPatterns.SelectMany(x => Directory.EnumerateFileSystemEntries(@this.FullName, x)).Distinct().Where(x => predicate(x)).ToArray();
        }

        public static string[] GetFileSystemEntriesWhere(this DirectoryInfo @this, String[] searchPatterns, SearchOption searchOption, Func<string, bool> predicate)
        {
            return searchPatterns.SelectMany(x => Directory.EnumerateFileSystemEntries(@this.FullName, x, searchOption)).Distinct().Where(x => predicate(x)).ToArray();
        }
    }
}
