using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 获取与指定搜索模式数组匹配的所有子目录。
        /// </summary>
        /// <param name="this">要搜索的目录。</param>
        /// <param name="searchPatterns">搜索模式数组（如 "*.txt", "data*"）。</param>
        /// <returns>匹配的 <see cref="DirectoryInfo"/> 数组，去重后返回。</returns>
        public static DirectoryInfo[] GetDirectories(this DirectoryInfo @this, string[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x)).Distinct().ToArray();
        }

        /// <summary>
        /// 获取与指定搜索模式数组匹配的所有子目录，并可指定搜索选项。
        /// </summary>
        /// <param name="this">要搜索的目录。</param>
        /// <param name="searchPatterns">搜索模式数组（如 "*.txt", "data*"）。</param>
        /// <param name="searchOption">指定搜索操作是仅当前目录还是包括所有子目录。</param>
        /// <returns>匹配的 <see cref="DirectoryInfo"/> 数组，去重后返回。</returns>
        public static DirectoryInfo[] GetDirectories(this DirectoryInfo @this, string[] searchPatterns, SearchOption searchOption)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x, searchOption)).Distinct().ToArray();
        }
    }
}
