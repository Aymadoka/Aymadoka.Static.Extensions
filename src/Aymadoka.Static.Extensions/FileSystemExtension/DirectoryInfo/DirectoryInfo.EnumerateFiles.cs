using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 按多个搜索模式枚举目录下的文件。
        /// </summary>
        /// <param name="this">目标目录。</param>
        /// <param name="searchPatterns">搜索模式数组。</param>
        /// <returns>文件信息集合。</returns>
        public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this, string[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x)).Distinct();
        }

        /// <summary>
        /// 按多个搜索模式和搜索选项枚举目录下的文件。
        /// </summary>
        /// <param name="this">目标目录。</param>
        /// <param name="searchPatterns">搜索模式数组。</param>
        /// <param name="searchOption">搜索选项（如是否包含子目录）。</param>
        /// <returns>文件信息集合。</returns>
        public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this, string[] searchPatterns, SearchOption searchOption)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x, searchOption)).Distinct();
        }
    }
}
