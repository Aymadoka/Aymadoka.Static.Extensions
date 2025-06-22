using System.IO.Compression;
using System.Text;

namespace Aymadoka.Static.ZipFileExtension
{
    public class ZipFile_CreateZipFileTests : IDisposable
    {
        private readonly string _testDir;
        private readonly string _testFile;
        private readonly string _zipFile;

        public ZipFile_CreateZipFileTests()
        {
            _testDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testDir);
            _testFile = Path.Combine(_testDir, "test.txt");
            File.WriteAllText(_testFile, "Hello, Zip!");

            _zipFile = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".zip");
        }

        [Fact]
        public void CreateZipFile_WithFileName_CreatesZip()
        {
            var dirInfo = new DirectoryInfo(_testDir);
            dirInfo.CreateZipFile(_zipFile);

            Assert.True(File.Exists(_zipFile));
            using var archive = ZipFile.OpenRead(_zipFile);
            Assert.Contains(archive.Entries, e => e.Name == "test.txt");
        }

        [Fact]
        public void CreateZipFile_WithCompressionLevelAndIncludeBase_CreatesZip()
        {
            var dirInfo = new DirectoryInfo(_testDir);
            dirInfo.CreateZipFile(_zipFile, CompressionLevel.Fastest, true);

            Assert.True(File.Exists(_zipFile));
            using var archive = ZipFile.OpenRead(_zipFile);
            Assert.Contains(archive.Entries, e => e.Name == "test.txt");
        }

        [Fact]
        public void CreateZipFile_WithEncoding_CreatesZip()
        {
            var dirInfo = new DirectoryInfo(_testDir);
            dirInfo.CreateZipFile(_zipFile, CompressionLevel.Optimal, false, Encoding.UTF8);

            Assert.True(File.Exists(_zipFile));
            using var archive = ZipFile.OpenRead(_zipFile);
            Assert.Contains(archive.Entries, e => e.Name == "test.txt");
        }

        [Fact]
        public void CreateZipFile_WithFileInfo_CreatesZip()
        {
            var dirInfo = new DirectoryInfo(_testDir);
            var fileInfo = new FileInfo(_zipFile);
            dirInfo.CreateZipFile(fileInfo);

            Assert.True(File.Exists(_zipFile));
            using var archive = ZipFile.OpenRead(_zipFile);
            Assert.Contains(archive.Entries, e => e.Name == "test.txt");
        }

        [Fact]
        public void CreateZipFile_WithFileInfoAndCompressionLevel_CreatesZip()
        {
            var dirInfo = new DirectoryInfo(_testDir);
            var fileInfo = new FileInfo(_zipFile);
            dirInfo.CreateZipFile(fileInfo, CompressionLevel.NoCompression, false);

            Assert.True(File.Exists(_zipFile));
            using var archive = ZipFile.OpenRead(_zipFile);
            Assert.Contains(archive.Entries, e => e.Name == "test.txt");
        }

        [Fact]
        public void CreateZipFile_WithFileInfoAndEncoding_CreatesZip()
        {
            var dirInfo = new DirectoryInfo(_testDir);
            var fileInfo = new FileInfo(_zipFile);
            dirInfo.CreateZipFile(fileInfo, CompressionLevel.Optimal, false, Encoding.UTF8);

            Assert.True(File.Exists(_zipFile));
            using var archive = ZipFile.OpenRead(_zipFile);
            Assert.Contains(archive.Entries, e => e.Name == "test.txt");
        }

        public void Dispose()
        {
            try
            {
                if (Directory.Exists(_testDir))
                    Directory.Delete(_testDir, true);
                if (File.Exists(_zipFile))
                    File.Delete(_zipFile);
            }
            catch { }
        }
    }
}
