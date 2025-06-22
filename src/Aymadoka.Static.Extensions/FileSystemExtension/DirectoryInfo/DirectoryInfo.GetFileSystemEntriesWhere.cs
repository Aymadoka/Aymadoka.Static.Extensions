using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 获取满足指定谓词的所有文件系统条目（文件和目录）。
        /// </summary>
        /// <param name="this">目标目录。</param>
        /// <param name="predicate">用于筛选条目的谓词。</param>
        /// <returns>满足条件的文件系统条目路径数组。</returns>
        public static string[] GetFileSystemEntriesWhere(this DirectoryInfo @this, Func<string, bool> predicate)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName).Where(x => predicate(x)).ToArray();
        }

        /// <summary>
        /// 获取满足指定谓词的所有文件系统条目（文件和目录），可指定搜索模式。
        /// </summary>
        /// <param name="this">目标目录。</param>
        /// <param name="searchPattern">搜索模式（如 "*.txt"）。</param>
        /// <param name="predicate">用于筛选条目的谓词。</param>
        /// <returns>满足条件的文件系统条目路径数组。</returns>
        public static string[] GetFileSystemEntriesWhere(this DirectoryInfo @this, String searchPattern, Func<string, bool> predicate)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName, searchPattern).Where(x => predicate(x)).ToArray();
        }

        /// <summary>
        /// 获取满足指定谓词的所有文件系统条目（文件和目录），可指定搜索模式和搜索选项。
        /// </summary>
        /// <param name="this">目标目录。</param>
        /// <param name="searchPattern">搜索模式（如 "*.txt"）。</param>
        /// <param name="searchOption">搜索选项（如是否递归子目录）。</param>
        /// <param name="predicate">用于筛选条目的谓词。</param>
        /// <returns>满足条件的文件系统条目路径数组。</returns>
        public static string[] GetFileSystemEntriesWhere(this DirectoryInfo @this, String searchPattern, SearchOption searchOption, Func<string, bool> predicate)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName, searchPattern, searchOption).Where(x => predicate(x)).ToArray();
        }

        /// <summary>
        /// 获取满足指定谓词的所有文件系统条目（文件和目录），可指定多个搜索模式。
        /// </summary>
        /// <param name="this">目标目录。</param>
        /// <param name="searchPatterns">搜索模式数组（如 new[] { "*.txt", "*.log" }）。</param>
        /// <param name="predicate">用于筛选条目的谓词。</param>
        /// <returns>满足条件的文件系统条目路径数组。</returns>
        public static string[] GetFileSystemEntriesWhere(this DirectoryInfo @this, String[] searchPatterns, Func<string, bool> predicate)
        {
            return searchPatterns.SelectMany(x => Directory.EnumerateFileSystemEntries(@this.FullName, x)).Distinct().Where(x => predicate(x)).ToArray();
        }

        /// <summary>
        /// 获取满足指定谓词的所有文件系统条目（文件和目录），可指定多个搜索模式和搜索选项。
        /// </summary>
        /// <param name="this">目标目录。</param>
        /// <param name="searchPatterns">搜索模式数组（如 new[] { "*.txt", "*.log" }）。</param>
        /// <param name="searchOption">搜索选项（如是否递归子目录）。</param>
        /// <param name="predicate">用于筛选条目的谓词。</param>
        /// <returns>满足条件的文件系统条目路径数组。</returns>
        public static string[] GetFileSystemEntriesWhere(this DirectoryInfo @this, String[] searchPatterns, SearchOption searchOption, Func<string, bool> predicate)
        {
            return searchPatterns.SelectMany(x => Directory.EnumerateFileSystemEntries(@this.FullName, x, searchOption)).Distinct().Where(x => predicate(x)).ToArray();
        }
    }
}
