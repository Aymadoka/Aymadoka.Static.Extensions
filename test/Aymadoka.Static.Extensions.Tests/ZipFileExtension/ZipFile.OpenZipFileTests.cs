using System.IO.Compression;
using System.Text;

namespace Aymadoka.Static.ZipFileExtension
{
    public class ZipFile_OpenZipFileTests : IDisposable
    {
        private readonly string _testZipPath;
        private readonly FileInfo _testZipFile;

        public ZipFile_OpenZipFileTests()
        {
            _testZipPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".zip");
            using (var archive = ZipFile.Open(_testZipPath, ZipArchiveMode.Create))
            {
                var entry = archive.CreateEntry("test.txt");
                using (var writer = new StreamWriter(entry.Open()))
                {
                    writer.Write("Hello, Zip!");
                }
            }
            _testZipFile = new FileInfo(_testZipPath);
        }

        [Fact]
        public void OpenZipFile_WithMode_ReturnsZipArchive()
        {
            using (var archive = _testZipFile.OpenZipFile(ZipArchiveMode.Read))
            {
                Assert.NotNull(archive);
                Assert.Single(archive.Entries);
                Assert.Equal("test.txt", archive.Entries[0].FullName);
            }
        }

        [Fact]
        public void OpenZipFile_WithModeAndEncoding_ReturnsZipArchive()
        {
            using (var archive = _testZipFile.OpenZipFile(ZipArchiveMode.Read, Encoding.UTF8))
            {
                Assert.NotNull(archive);
                Assert.Single(archive.Entries);
                Assert.Equal("test.txt", archive.Entries[0].FullName);
            }
        }

        public void Dispose()
        {
            if (File.Exists(_testZipPath))
            {
                File.Delete(_testZipPath);
            }
        }
    }
}
