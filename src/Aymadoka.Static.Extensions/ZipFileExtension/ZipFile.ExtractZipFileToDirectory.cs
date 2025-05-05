using System.IO;
using System.IO.Compression;
using System.Text;

namespace Aymadoka.Static.ZipFileExtension
{
    public static partial class ZipFileExtensions
    {
        public static void ExtractZipFileToDirectory(this FileInfo @this, string destinationDirectoryName)
        {
            ZipFile.ExtractToDirectory(@this.FullName, destinationDirectoryName);
        }

        public static void ExtractZipFileToDirectory(this FileInfo @this, string destinationDirectoryName, Encoding entryNameEncoding)
        {
            ZipFile.ExtractToDirectory(@this.FullName, destinationDirectoryName, entryNameEncoding);
        }

        public static void ExtractZipFileToDirectory(this FileInfo @this, DirectoryInfo destinationDirectory)
        {
            ZipFile.ExtractToDirectory(@this.FullName, destinationDirectory.FullName);
        }

        public static void ExtractZipFileToDirectory(this FileInfo @this, DirectoryInfo destinationDirectory, Encoding entryNameEncoding)
        {
            ZipFile.ExtractToDirectory(@this.FullName, destinationDirectory.FullName, entryNameEncoding);
        }
    }
}
