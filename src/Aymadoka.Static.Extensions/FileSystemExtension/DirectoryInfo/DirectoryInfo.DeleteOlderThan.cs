using System;
using System.IO;
using System.Linq;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 删除当前目录下所有最后写入时间早于指定时间跨度的文件和子目录（不递归子目录）。
        /// </summary>
        /// <param name="obj">要操作的目录。</param>
        /// <param name="timeSpan">时间跨度，早于此跨度的文件和目录将被删除。</param>
        public static void DeleteOlderThan(this DirectoryInfo obj, TimeSpan timeSpan)
        {
            DateTime minDate = DateTime.Now.Subtract(timeSpan);
            obj.GetFiles().Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
            obj.GetDirectories().Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
        }

        /// <summary>
        /// 删除当前目录及其子目录下所有最后写入时间早于指定时间跨度的文件和子目录。
        /// </summary>
        /// <param name="obj">要操作的目录。</param>
        /// <param name="searchOption">指定搜索操作是仅限于当前目录还是包括所有子目录。</param>
        /// <param name="timeSpan">时间跨度，早于此跨度的文件和目录将被删除。</param>
        public static void DeleteOlderThan(this DirectoryInfo obj, SearchOption searchOption, TimeSpan timeSpan)
        {
            DateTime minDate = DateTime.Now.Subtract(timeSpan);
            obj.GetFiles("*.*", searchOption).Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
            obj.GetDirectories("*.*", searchOption).Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
        }
    }
}
