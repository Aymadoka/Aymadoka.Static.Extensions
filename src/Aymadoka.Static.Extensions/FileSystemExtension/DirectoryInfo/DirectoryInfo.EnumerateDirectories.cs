using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 按多个搜索模式枚举当前目录下的子目录。
        /// </summary>
        /// <param name="this">当前目录。</param>
        /// <param name="searchPatterns">搜索模式数组。</param>
        /// <returns>匹配的子目录的 <see cref="DirectoryInfo"/> 集合。</returns>
        public static IEnumerable<DirectoryInfo> EnumerateDirectories(this DirectoryInfo @this, string[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x)).Distinct();
        }

        /// <summary>
        /// 按多个搜索模式和搜索选项枚举当前目录下的子目录。
        /// </summary>
        /// <param name="this">当前目录。</param>
        /// <param name="searchPatterns">搜索模式数组。</param>
        /// <param name="searchOption">搜索选项，指定是否搜索所有子目录。</param>
        /// <returns>匹配的子目录的 <see cref="DirectoryInfo"/> 集合。</returns>
        public static IEnumerable<DirectoryInfo> EnumerateDirectories(this DirectoryInfo @this, string[] searchPatterns, SearchOption searchOption)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x, searchOption)).Distinct();
        }
    }
}
