using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 枚举指定目录中的所有文件和目录的路径。
        /// </summary>
        /// <param name="this">要枚举的目录。</param>
        /// <returns>包含所有文件和目录路径的枚举集合。</returns>
        public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName);
        }

        /// <summary>
        /// 按指定的搜索模式枚举目录中的所有文件和目录的路径。
        /// </summary>
        /// <param name="this">要枚举的目录。</param>
        /// <param name="searchPattern">搜索字符串，可以包含有效的通配符（* 和 ?）。</param>
        /// <returns>包含匹配文件和目录路径的枚举集合。</returns>
        public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this, string searchPattern)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName, searchPattern);
        }

        /// <summary>
        /// 按指定的搜索模式和搜索选项枚举目录中的所有文件和目录的路径。
        /// </summary>
        /// <param name="this">要枚举的目录。</param>
        /// <param name="searchPattern">搜索字符串，可以包含有效的通配符（* 和 ?）。</param>
        /// <param name="searchOption">指定是仅搜索当前目录还是包括所有子目录。</param>
        /// <returns>包含匹配文件和目录路径的枚举集合。</returns>
        public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this, string searchPattern, SearchOption searchOption)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName, searchPattern, searchOption);
        }

        /// <summary>
        /// 按多个搜索模式枚举目录中的所有文件和目录的路径。
        /// </summary>
        /// <param name="this">要枚举的目录。</param>
        /// <param name="searchPatterns">搜索字符串数组，每个字符串可以包含有效的通配符（* 和 ?）。</param>
        /// <returns>包含所有匹配文件和目录路径的去重枚举集合。</returns>
        public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this, string[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => Directory.EnumerateFileSystemEntries(@this.FullName, x)).Distinct();
        }

        /// <summary>
        /// 按多个搜索模式和搜索选项枚举目录中的所有文件和目录的路径。
        /// </summary>
        /// <param name="this">要枚举的目录。</param>
        /// <param name="searchPatterns">搜索字符串数组，每个字符串可以包含有效的通配符（* 和 ?）。</param>
        /// <param name="searchOption">指定是仅搜索当前目录还是包括所有子目录。</param>
        /// <returns>包含所有匹配文件和目录路径的去重枚举集合。</returns>
        public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this, string[] searchPatterns, SearchOption searchOption)
        {
            return searchPatterns.SelectMany(x => Directory.EnumerateFileSystemEntries(@this.FullName, x, searchOption)).Distinct();
        }
    }
}
