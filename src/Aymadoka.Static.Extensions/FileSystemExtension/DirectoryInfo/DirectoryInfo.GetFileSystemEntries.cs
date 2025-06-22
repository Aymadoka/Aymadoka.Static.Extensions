using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 获取指定目录下的所有文件和目录的完整路径。
        /// </summary>
        /// <param name="this">要枚举的目录。</param>
        /// <returns>所有文件和目录的完整路径数组。</returns>
        public static string[] GetFileSystemEntries(this DirectoryInfo @this)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName).ToArray();
        }

        /// <summary>
        /// 获取与指定搜索模式匹配的所有文件和目录的完整路径。
        /// </summary>
        /// <param name="this">要枚举的目录。</param>
        /// <param name="searchPattern">搜索字符串，可以包含通配符。</param>
        /// <returns>匹配的文件和目录的完整路径数组。</returns>
        public static string[] GetFileSystemEntries(this DirectoryInfo @this, String searchPattern)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName, searchPattern).ToArray();
        }

        /// <summary>
        /// 获取与指定搜索模式和搜索选项匹配的所有文件和目录的完整路径。
        /// </summary>
        /// <param name="this">要枚举的目录。</param>
        /// <param name="searchPattern">搜索字符串，可以包含通配符。</param>
        /// <param name="searchOption">指定是仅搜索当前目录还是包括所有子目录。</param>
        /// <returns>匹配的文件和目录的完整路径数组。</returns>
        public static string[] GetFileSystemEntries(this DirectoryInfo @this, String searchPattern, SearchOption searchOption)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName, searchPattern, searchOption).ToArray();
        }

        /// <summary>
        /// 获取与指定多个搜索模式匹配的所有文件和目录的完整路径。
        /// </summary>
        /// <param name="this">要枚举的目录。</param>
        /// <param name="searchPatterns">搜索字符串数组，每个可以包含通配符。</param>
        /// <returns>匹配的文件和目录的完整路径数组（去重）。</returns>
        public static string[] GetFileSystemEntries(this DirectoryInfo @this, String[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => Directory.EnumerateFileSystemEntries(@this.FullName, x)).Distinct().ToArray();
        }

        /// <summary>
        /// 获取与指定多个搜索模式和搜索选项匹配的所有文件和目录的完整路径。
        /// </summary>
        /// <param name="this">要枚举的目录。</param>
        /// <param name="searchPatterns">搜索字符串数组，每个可以包含通配符。</param>
        /// <param name="searchOption">指定是仅搜索当前目录还是包括所有子目录。</param>
        /// <returns>匹配的文件和目录的完整路径数组（去重）。</returns>
        public static string[] GetFileSystemEntries(this DirectoryInfo @this, String[] searchPatterns, SearchOption searchOption)
        {
            return searchPatterns.SelectMany(x => Directory.EnumerateFileSystemEntries(@this.FullName, x, searchOption)).Distinct().ToArray();
        }
    }
}
