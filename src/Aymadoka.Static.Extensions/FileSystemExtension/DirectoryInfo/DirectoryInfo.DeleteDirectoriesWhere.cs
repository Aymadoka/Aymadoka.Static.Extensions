using Aymadoka.Static.EnumerableExtension;
using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 删除根目录下所有满足指定条件的子目录（仅限顶层目录）。
        /// </summary>
        /// <param name="root">根目录。</param>
        /// <param name="predicate">用于判断目录是否应被删除的条件。</param>
        public static void DeleteDirectoriesWhere(this DirectoryInfo root, Predicate<DirectoryInfo> predicate)
        {
            DeleteDirectoriesWhere(root, SearchOption.TopDirectoryOnly, predicate);
        }

        /// <summary>
        /// 删除根目录下所有满足指定条件的子目录，可指定搜索选项（顶层或递归）。
        /// </summary>
        /// <param name="root">根目录。</param>
        /// <param name="searchOption">搜索选项，决定是否递归子目录。</param>
        /// <param name="predicate">用于判断目录是否应被删除的条件。</param>
        public static void DeleteDirectoriesWhere(this DirectoryInfo root, SearchOption searchOption, Predicate<DirectoryInfo> predicate)
        {
            // 先递归获取所有匹配的目录，按深度倒序删除，确保先删子目录
            var directories = root.EnumerateDirectories("*", searchOption)
                .OrderByDescending(d => d.FullName.Count(c => c == Path.DirectorySeparatorChar))
                .Where(d => predicate(d))
                .ToList();

            foreach (var dir in directories)
            {
                dir.Delete(true); // true 表示递归删除
            }
        }
    }
}
