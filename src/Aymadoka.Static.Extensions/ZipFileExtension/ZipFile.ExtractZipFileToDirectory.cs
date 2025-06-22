using System.IO;
using System.IO.Compression;
using System.Text;

namespace Aymadoka.Static.ZipFileExtension
{
    public static partial class ZipFileExtensions
    {
        /// <summary>
        /// 将当前 <see cref="FileInfo"/> 表示的 Zip 文件解压到指定目录。
        /// </summary>
        /// <param name="this">Zip 文件的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="destinationDirectoryName">目标解压目录路径。</param>
        public static void ExtractZipFileToDirectory(this FileInfo @this, string destinationDirectoryName)
        {
            ZipFile.ExtractToDirectory(@this.FullName, destinationDirectoryName);
        }

        /// <summary>
        /// 将当前 <see cref="FileInfo"/> 表示的 Zip 文件解压到指定目录，并指定条目名称编码。
        /// </summary>
        /// <param name="this">Zip 文件的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="destinationDirectoryName">目标解压目录路径。</param>
        /// <param name="entryNameEncoding">Zip 条目名称的编码。</param>
        public static void ExtractZipFileToDirectory(this FileInfo @this, string destinationDirectoryName, Encoding entryNameEncoding)
        {
            ZipFile.ExtractToDirectory(@this.FullName, destinationDirectoryName, entryNameEncoding);
        }

        /// <summary>
        /// 将当前 <see cref="FileInfo"/> 表示的 Zip 文件解压到指定 <see cref="DirectoryInfo"/> 目录。
        /// </summary>
        /// <param name="this">Zip 文件的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="destinationDirectory">目标解压目录的 <see cref="DirectoryInfo"/> 实例。</param>
        public static void ExtractZipFileToDirectory(this FileInfo @this, DirectoryInfo destinationDirectory)
        {
            ZipFile.ExtractToDirectory(@this.FullName, destinationDirectory.FullName);
        }

        /// <summary>
        /// 将当前 <see cref="FileInfo"/> 表示的 Zip 文件解压到指定 <see cref="DirectoryInfo"/> 目录，并指定条目名称编码。
        /// </summary>
        /// <param name="this">Zip 文件的 <see cref="FileInfo"/> 实例。</param>
        /// <param name="destinationDirectory">目标解压目录的 <see cref="DirectoryInfo"/> 实例。</param>
        /// <param name="entryNameEncoding">Zip 条目名称的编码。</param>
        public static void ExtractZipFileToDirectory(this FileInfo @this, DirectoryInfo destinationDirectory, Encoding entryNameEncoding)
        {
            ZipFile.ExtractToDirectory(@this.FullName, destinationDirectory.FullName, entryNameEncoding);
        }
    }
}
