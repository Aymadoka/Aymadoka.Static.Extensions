using System.IO;
using System.IO.Compression;

namespace Aymadoka.Static.ZipFileExtension
{
    public static partial class ZipFileExtensions
    {
        public static ZipArchive OpenReadZipFile(this FileInfo @this)
        {
            return ZipFile.OpenRead(@this.FullName);
        }
    }
}
