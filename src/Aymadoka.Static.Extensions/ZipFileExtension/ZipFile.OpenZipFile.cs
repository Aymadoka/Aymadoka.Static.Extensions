using System.IO;
using System.IO.Compression;
using System.Text;

namespace Aymadoka.Static.ZipFileExtension
{
    public static partial class ZipFileExtensions
    {
        public static ZipArchive OpenZipFile(this FileInfo @this, ZipArchiveMode mode)
        {
            return ZipFile.Open(@this.FullName, mode);
        }

        public static ZipArchive OpenZipFile(this FileInfo @this, ZipArchiveMode mode, Encoding entryNameEncoding)
        {
            return ZipFile.Open(@this.FullName, mode, entryNameEncoding);
        }
    }
}
