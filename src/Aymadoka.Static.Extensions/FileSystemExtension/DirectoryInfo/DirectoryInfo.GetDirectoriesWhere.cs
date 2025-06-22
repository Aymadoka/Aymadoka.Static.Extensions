using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 获取当前目录下所有满足指定条件的子目录。
        /// </summary>
        /// <param name="this">当前目录。</param>
        /// <param name="predicate">用于筛选目录的条件。</param>
        /// <returns>满足条件的子目录数组。</returns>
        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this, Func<DirectoryInfo, bool> predicate)
        {
            return Directory.EnumerateDirectories(@this.FullName).Select(x => new DirectoryInfo(x)).Where(x => predicate(x)).ToArray();
        }

        /// <summary>
        /// 获取当前目录下所有名称匹配指定模式且满足条件的子目录。
        /// </summary>
        /// <param name="this">当前目录。</param>
        /// <param name="searchPattern">搜索模式。</param>
        /// <param name="predicate">用于筛选目录的条件。</param>
        /// <returns>满足条件的子目录数组。</returns>
        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this, String searchPattern, Func<DirectoryInfo, bool> predicate)
        {
            return Directory.EnumerateDirectories(@this.FullName, searchPattern).Select(x => new DirectoryInfo(x)).Where(x => predicate(x)).ToArray();
        }

        /// <summary>
        /// 获取当前目录下所有名称匹配指定模式、搜索选项且满足条件的子目录。
        /// </summary>
        /// <param name="this">当前目录。</param>
        /// <param name="searchPattern">搜索模式。</param>
        /// <param name="searchOption">搜索选项（是否递归子目录）。</param>
        /// <param name="predicate">用于筛选目录的条件。</param>
        /// <returns>满足条件的子目录数组。</returns>
        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this, String searchPattern, SearchOption searchOption, Func<DirectoryInfo, bool> predicate)
        {
            return Directory.EnumerateDirectories(@this.FullName, searchPattern, searchOption).Select(x => new DirectoryInfo(x)).Where(x => predicate(x)).ToArray();
        }

        /// <summary>
        /// 获取当前目录下所有名称匹配任意指定模式且满足条件的子目录。
        /// </summary>
        /// <param name="this">当前目录。</param>
        /// <param name="searchPatterns">搜索模式数组。</param>
        /// <param name="predicate">用于筛选目录的条件。</param>
        /// <returns>满足条件的子目录数组。</returns>
        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this, String[] searchPatterns, Func<DirectoryInfo, bool> predicate)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x)).Distinct().Where(x => predicate(x)).ToArray();
        }

        /// <summary>
        /// 获取当前目录下所有名称匹配任意指定模式、搜索选项且满足条件的子目录。
        /// </summary>
        /// <param name="this">当前目录。</param>
        /// <param name="searchPatterns">搜索模式数组。</param>
        /// <param name="searchOption">搜索选项（是否递归子目录）。</param>
        /// <param name="predicate">用于筛选目录的条件。</param>
        /// <returns>满足条件的子目录数组。</returns>
        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this, String[] searchPatterns, SearchOption searchOption, Func<DirectoryInfo, bool> predicate)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x, searchOption)).Distinct().Where(x => predicate(x)).ToArray();
        }
    }
}
