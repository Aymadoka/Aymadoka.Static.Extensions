using System.IO;
using System.IO.Compression;
using System.Text;

namespace Aymadoka.Static.ZipFileExtension
{
    public static partial class ZipFileExtensions
    {
        public static void CreateZipFile(this DirectoryInfo @this, string destinationArchiveFileName)
        {
            ZipFile.CreateFromDirectory(@this.FullName, destinationArchiveFileName);
        }

        public static void CreateZipFile(this DirectoryInfo @this, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory)
        {
            ZipFile.CreateFromDirectory(@this.FullName, destinationArchiveFileName, compressionLevel, includeBaseDirectory);
        }

        public static void CreateZipFile(this DirectoryInfo @this, string destinationArchiveFileName, CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding)
        {
            ZipFile.CreateFromDirectory(@this.FullName, destinationArchiveFileName, compressionLevel, includeBaseDirectory, entryNameEncoding);
        }

        public static void CreateZipFile(this DirectoryInfo @this, FileInfo destinationArchiveFile)
        {
            ZipFile.CreateFromDirectory(@this.FullName, destinationArchiveFile.FullName);
        }

        public static void CreateZipFile(this DirectoryInfo @this, FileInfo destinationArchiveFile, CompressionLevel compressionLevel, bool includeBaseDirectory)
        {
            ZipFile.CreateFromDirectory(@this.FullName, destinationArchiveFile.FullName, compressionLevel, includeBaseDirectory);
        }

        public static void CreateZipFile(this DirectoryInfo @this, FileInfo destinationArchiveFile, CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding entryNameEncoding)
        {
            ZipFile.CreateFromDirectory(@this.FullName, destinationArchiveFile.FullName, compressionLevel, includeBaseDirectory, entryNameEncoding);
        }
    }
}
