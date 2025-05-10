using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, Func<FileInfo, bool> predicate)
        {
            return Directory.EnumerateFiles(@this.FullName).Select(x => new FileInfo(x)).Where(x => predicate(x)).ToArray();
        }

        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, String searchPattern, Func<FileInfo, bool> predicate)
        {
            return Directory.EnumerateFiles(@this.FullName, searchPattern).Select(x => new FileInfo(x)).Where(x => predicate(x)).ToArray();
        }

        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, String searchPattern, SearchOption searchOption, Func<FileInfo, bool> predicate)
        {
            return Directory.EnumerateFiles(@this.FullName, searchPattern, searchOption).Select(x => new FileInfo(x)).Where(x => predicate(x)).ToArray();
        }

        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, String[] searchPatterns, Func<FileInfo, bool> predicate)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x)).Distinct().Where(x => predicate(x)).ToArray();
        }

        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, String[] searchPatterns, SearchOption searchOption, Func<FileInfo, bool> predicate)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x, searchOption)).Distinct().Where(x => predicate(x)).ToArray();
        }
    }
}
