using System.IO;
using System.IO.Compression;
using System.Text;

namespace Aymadoka.Static.ZipFileExtension
{
    public static partial class ZipFileExtensions
    {
        /// <summary>
        /// 将指定目录内容压缩为 ZIP 文件。
        /// </summary>
        /// <param name="this">要压缩的目录。</param>
        /// <param name="destinationArchiveFileName">目标 ZIP 文件路径。</param>
        public static void CreateZipFile(this DirectoryInfo @this, string destinationArchiveFileName)
        {
            ZipFile.CreateFromDirectory(@this.FullName, destinationArchiveFileName);
        }

        /// <summary>
        /// 将指定目录内容压缩为 ZIP 文件，并指定压缩级别和是否包含基础目录。
        /// </summary>
        /// <param name="this">要压缩的目录。</param>
        /// <param name="destinationArchiveFileName">目标 ZIP 文件路径。</param>
        /// <param name="compressionLevel">压缩级别。</param>
        /// <param name="includeBaseDirectory">是否包含基础目录。</param>
        public static void CreateZipFile(this DirectoryInfo @this, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory)
        {
            ZipFile.CreateFromDirectory(@this.FullName, destinationArchiveFileName, compressionLevel, includeBaseDirectory);
        }

        /// <summary>
        /// 将指定目录内容压缩为 ZIP 文件，并指定压缩级别、是否包含基础目录和条目名称编码。
        /// </summary>
        /// <param name="this">要压缩的目录。</param>
        /// <param name="destinationArchiveFileName">目标 ZIP 文件路径。</param>
        /// <param name="compressionLevel">压缩级别。</param>
        /// <param name="includeBaseDirectory">是否包含基础目录。</param>
        /// <param name="entryNameEncoding">ZIP 条目名称编码。</param>
        public static void CreateZipFile(this DirectoryInfo @this, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding)
        {
            ZipFile.CreateFromDirectory(@this.FullName, destinationArchiveFileName, compressionLevel, includeBaseDirectory, entryNameEncoding);
        }

        /// <summary>
        /// 将指定目录内容压缩为 ZIP 文件。
        /// </summary>
        /// <param name="this">要压缩的目录。</param>
        /// <param name="destinationArchiveFile">目标 ZIP 文件。</param>
        public static void CreateZipFile(this DirectoryInfo @this, FileInfo destinationArchiveFile)
        {
            ZipFile.CreateFromDirectory(@this.FullName, destinationArchiveFile.FullName);
        }

        /// <summary>
        /// 将指定目录内容压缩为 ZIP 文件，并指定压缩级别和是否包含基础目录。
        /// </summary>
        /// <param name="this">要压缩的目录。</param>
        /// <param name="destinationArchiveFile">目标 ZIP 文件。</param>
        /// <param name="compressionLevel">压缩级别。</param>
        /// <param name="includeBaseDirectory">是否包含基础目录。</param>
        public static void CreateZipFile(this DirectoryInfo @this, FileInfo destinationArchiveFile, CompressionLevel compressionLevel, bool includeBaseDirectory)
        {
            ZipFile.CreateFromDirectory(@this.FullName, destinationArchiveFile.FullName, compressionLevel, includeBaseDirectory);
        }

        /// <summary>
        /// 将指定目录内容压缩为 ZIP 文件，并指定压缩级别、是否包含基础目录和条目名称编码。
        /// </summary>
        /// <param name="this">要压缩的目录。</param>
        /// <param name="destinationArchiveFile">目标 ZIP 文件。</param>
        /// <param name="compressionLevel">压缩级别。</param>
        /// <param name="includeBaseDirectory">是否包含基础目录。</param>
        /// <param name="entryNameEncoding">ZIP 条目名称编码。</param>
        public static void CreateZipFile(this DirectoryInfo @this, FileInfo destinationArchiveFile, CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding)
        {
            ZipFile.CreateFromDirectory(@this.FullName, destinationArchiveFile.FullName, compressionLevel, includeBaseDirectory, entryNameEncoding);
        }
    }
}
