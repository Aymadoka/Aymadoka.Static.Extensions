using System;
using System.IO;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// 复制当前目录下的所有文件（不包含子目录）到指定目标目录。
        /// </summary>
        /// <param name="obj">源目录。</param>
        /// <param name="destDirName">目标目录路径。</param>
        public static void CopyTo(this DirectoryInfo obj, string destDirName)
        {
            obj.CopyTo(destDirName, "*.*", SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// 复制当前目录下符合搜索模式的所有文件（不包含子目录）到指定目标目录。
        /// </summary>
        /// <param name="obj">源目录。</param>
        /// <param name="destDirName">目标目录路径。</param>
        /// <param name="searchPattern">文件搜索模式。</param>
        public static void CopyTo(this DirectoryInfo obj, string destDirName, string searchPattern)
        {
            obj.CopyTo(destDirName, searchPattern, SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// 复制当前目录及其子目录下的所有文件到指定目标目录。
        /// </summary>
        /// <param name="obj">源目录。</param>
        /// <param name="destDirName">目标目录路径。</param>
        /// <param name="searchOption">搜索选项，指定是否包含子目录。</param>
        public static void CopyTo(this DirectoryInfo obj, string destDirName, SearchOption searchOption)
        {
            obj.CopyTo(destDirName, "*.*", searchOption);
        }

        /// <summary>
        /// 复制当前目录及其子目录下符合搜索模式的所有文件和空目录到指定目标目录。
        /// </summary>
        /// <param name="obj">源目录。</param>
        /// <param name="destDirName">目标目录路径。</param>
        /// <param name="searchPattern">文件搜索模式。</param>
        /// <param name="searchOption">搜索选项，指定是否包含子目录。</param>
        public static void CopyTo(this DirectoryInfo obj, string destDirName, string searchPattern, SearchOption searchOption)
        {
            var files = obj.GetFiles(searchPattern, searchOption);
            foreach (var file in files)
            {
                var outputFile = destDirName + file.FullName.Substring(obj.FullName.Length);
                var directory = new FileInfo(outputFile).Directory;

                if (!directory.Exists)
                {
                    directory.Create();
                }

                file.CopyTo(outputFile);
            }

            // 确保空目录也被复制
            var directories = obj.GetDirectories(searchPattern, searchOption);
            foreach (var directory in directories)
            {
                var outputDirectory = destDirName + directory.FullName.Substring(obj.FullName.Length);
                var directoryInfo = new DirectoryInfo(outputDirectory);
                if (!directoryInfo.Exists)
                {
                    directoryInfo.Create();
                }
            }
        }
    }
}
