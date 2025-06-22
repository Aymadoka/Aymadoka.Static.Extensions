using System.IO.Compression;

namespace Aymadoka.Static.ZipFileExtension
{
    public class ZipFile_OpenReadZipFileTests : IDisposable
    {
        private readonly string _testZipPath;
        private readonly FileInfo _testZipFile;

        public ZipFile_OpenReadZipFileTests()
        {
            _testZipPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".zip");
            using (var zip = ZipFile.Open(_testZipPath, ZipArchiveMode.Create))
            {
                var entry = zip.CreateEntry("test.txt");
                using (var writer = new StreamWriter(entry.Open()))
                {
                    writer.Write("hello");
                }
            }
            _testZipFile = new FileInfo(_testZipPath);
        }

        [Fact]
        public void OpenReadZipFile_ShouldOpenZipArchiveInReadMode()
        {
            using (var archive = _testZipFile.OpenReadZipFile())
            {
                Assert.NotNull(archive);
                Assert.Equal(ZipArchiveMode.Read, archive.Mode);
                var entry = archive.GetEntry("test.txt");
                Assert.NotNull(entry);
                using (var reader = new StreamReader(entry.Open()))
                {
                    var content = reader.ReadToEnd();
                    Assert.Equal("hello", content);
                }
            }
        }

        [Fact]
        public void OpenReadZipFile_ShouldThrowIfFileDoesNotExist()
        {
            var nonExistentFile = new FileInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".zip"));
            Assert.Throws<FileNotFoundException>(() =>
            {
                using var archive = nonExistentFile.OpenReadZipFile();
            });
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
