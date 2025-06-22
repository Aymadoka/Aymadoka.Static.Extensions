using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 获取与任意指定搜索模式匹配的所有文件。
        /// </summary>
        /// <param name="this">要搜索的目录。</param>
        /// <param name="searchPatterns">文件搜索模式数组（如 "*.txt", "*.jpg"）。</param>
        /// <returns>所有匹配文件的 <see cref="FileInfo"/> 数组，去重后返回。</returns>
        public static FileInfo[] GetFiles(this DirectoryInfo @this, String[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x)).Distinct().ToArray();
        }

        /// <summary>
        /// 获取与任意指定搜索模式匹配的所有文件，并指定搜索选项。
        /// </summary>
        /// <param name="this">要搜索的目录。</param>
        /// <param name="searchPatterns">文件搜索模式数组（如 "*.txt", "*.jpg"）。</param>
        /// <param name="searchOption">指定搜索子目录的选项。</param>
        /// <returns>所有匹配文件的 <see cref="FileInfo"/> 数组，去重后返回。</returns>
        public static FileInfo[] GetFiles(this DirectoryInfo @this, String[] searchPatterns, SearchOption searchOption)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x, searchOption)).Distinct().ToArray();
        }
    }
}
