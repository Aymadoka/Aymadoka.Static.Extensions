using System;
using System.IO;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public static partial class DirectoryInfoExtensions
    {
        public static void CopyTo(this DirectoryInfo obj, string destDirName)
        {
            obj.CopyTo(destDirName, "*.*", SearchOption.TopDirectoryOnly);
        }

        public static void CopyTo(this DirectoryInfo obj, string destDirName, string searchPattern)
        {
            obj.CopyTo(destDirName, searchPattern, SearchOption.TopDirectoryOnly);
        }

        public static void CopyTo(this DirectoryInfo obj, string destDirName, SearchOption searchOption)
        {
            obj.CopyTo(destDirName, "*.*", searchOption);
        }

        public static void CopyTo(this DirectoryInfo obj, string destDirName, string searchPattern, SearchOption searchOption)
        {
            var files = obj.GetFiles(searchPattern, searchOption);
            foreach (var file in files)
            {
                var outputFile = destDirName + file.FullName.Substring(obj.FullName.Length);
                var directory = new FileInfo(outputFile).Directory;

                if (directory == null)
                {
                    throw new ArgumentNullException("The directory cannot be null.");
                }

                if (!directory.Exists)
                {
                    directory.Create();
                }

                file.CopyTo(outputFile);
            }

            // Ensure empty dir are also copied
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
