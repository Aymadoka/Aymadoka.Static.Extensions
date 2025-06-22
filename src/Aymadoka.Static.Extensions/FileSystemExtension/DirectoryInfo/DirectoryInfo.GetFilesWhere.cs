using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 获取目录下所有满足条件的文件。
        /// </summary>
        /// <param name="this">目录信息。</param>
        /// <param name="predicate">文件筛选条件。</param>
        /// <returns>满足条件的文件数组。</returns>
        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, Func<FileInfo, bool> predicate)
        {
            return Directory.EnumerateFiles(@this.FullName).Select(x => new FileInfo(x)).Where(x => predicate(x)).ToArray();
        }

        /// <summary>
        /// 获取目录下所有匹配搜索模式且满足条件的文件。
        /// </summary>
        /// <param name="this">目录信息。</param>
        /// <param name="searchPattern">搜索模式（如 "*.txt"）。</param>
        /// <param name="predicate">文件筛选条件。</param>
        /// <returns>满足条件的文件数组。</returns>
        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, String searchPattern, Func<FileInfo, bool> predicate)
        {
            return Directory.EnumerateFiles(@this.FullName, searchPattern).Select(x => new FileInfo(x)).Where(x => predicate(x)).ToArray();
        }

        /// <summary>
        /// 获取目录下所有匹配搜索模式、搜索选项且满足条件的文件。
        /// </summary>
        /// <param name="this">目录信息。</param>
        /// <param name="searchPattern">搜索模式（如 "*.txt"）。</param>
        /// <param name="searchOption">搜索选项（如是否包含子目录）。</param>
        /// <param name="predicate">文件筛选条件。</param>
        /// <returns>满足条件的文件数组。</returns>
        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, String searchPattern, SearchOption searchOption, Func<FileInfo, bool> predicate)
        {
            return Directory.EnumerateFiles(@this.FullName, searchPattern, searchOption).Select(x => new FileInfo(x)).Where(x => predicate(x)).ToArray();
        }

        /// <summary>
        /// 获取目录下所有匹配任意搜索模式且满足条件的文件。
        /// </summary>
        /// <param name="this">目录信息。</param>
        /// <param name="searchPatterns">搜索模式数组。</param>
        /// <param name="predicate">文件筛选条件。</param>
        /// <returns>满足条件的文件数组。</returns>
        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, String[] searchPatterns, Func<FileInfo, bool> predicate)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x)).Distinct().Where(x => predicate(x)).ToArray();
        }

        /// <summary>
        /// 获取目录下所有匹配任意搜索模式、搜索选项且满足条件的文件。
        /// </summary>
        /// <param name="this">目录信息。</param>
        /// <param name="searchPatterns">搜索模式数组。</param>
        /// <param name="searchOption">搜索选项（如是否包含子目录）。</param>
        /// <param name="predicate">文件筛选条件。</param>
        /// <returns>满足条件的文件数组。</returns>
        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, String[] searchPatterns, SearchOption searchOption, Func<FileInfo, bool> predicate)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x, searchOption)).Distinct().Where(x => predicate(x)).ToArray();
        }
    }
}
