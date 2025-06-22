using Aymadoka.Static.EnumerableExtension;
using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 删除当前目录下所有满足指定条件的文件。
        /// </summary>
        /// <param name="obj">要操作的目录。</param>
        /// <param name="predicate">用于筛选文件的条件。</param>
        public static void DeleteFilesWhere(this DirectoryInfo obj, Func<FileInfo, bool> predicate)
        {
            obj.GetFiles().Where(predicate).ForEach(x => x.Delete());
        }

        /// <summary>
        /// 删除当前目录及其子目录下所有满足指定条件的文件。
        /// </summary>
        /// <param name="obj">要操作的目录。</param>
        /// <param name="searchOption">指定搜索操作是仅限于当前目录还是包括所有子目录。</param>
        /// <param name="predicate">用于筛选文件的条件。</param>
        public static void DeleteFilesWhere(this DirectoryInfo obj, SearchOption searchOption, Func<FileInfo, bool> predicate)
        {
            obj.GetFiles("*.*", searchOption).Where(predicate).ForEach(x => x.Delete());
        }
    }
}
