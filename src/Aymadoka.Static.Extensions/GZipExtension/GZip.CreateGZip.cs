using System.IO;
using System.IO.Compression;

namespace Aymadoka.Static.GZipExtension
{
    public static partial class GZipExtensions
    {
        public static void CreateGZip(this FileInfo @this)
        {
            using (FileStream originalFileStream = @this.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(@this.FullName + ".gz"))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        public static void CreateGZip(this FileInfo @this, string destination)
        {
            using (FileStream originalFileStream = @this.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(destination))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        public static void CreateGZip(this FileInfo @this, FileInfo destination)
        {
            using (FileStream originalFileStream = @this.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(destination.FullName))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }
    }
}
