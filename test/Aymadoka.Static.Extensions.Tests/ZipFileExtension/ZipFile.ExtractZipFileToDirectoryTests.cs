using System.IO.Compression;
using System.Text;

namespace Aymadoka.Static.ZipFileExtension
{
    public class ZipFile_ExtractZipFileToDirectoryTests : IDisposable
    {
        private readonly string _tempDir;
        private readonly string _zipFilePath;
        private readonly string _testFileName = "test.txt";
        private readonly string _testFileContent = "Hello, Zip!";

        public ZipFile_ExtractZipFileToDirectoryTests()
        {
            _tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_tempDir);

            // 创建一个 zip 文件
            _zipFilePath = Path.Combine(_tempDir, "test.zip");
            using (var zip = ZipFile.Open(_zipFilePath, ZipArchiveMode.Create, Encoding.UTF8))
            {
                var entry = zip.CreateEntry(_testFileName);
                using (var writer = new StreamWriter(entry.Open(), Encoding.UTF8))
                {
                    writer.Write(_testFileContent);
                }
            }
        }

        [Fact]
        public void ExtractZipFileToDirectory_StringPath_Works()
        {
            var destDir = Path.Combine(_tempDir, "extract1");
            var fileInfo = new FileInfo(_zipFilePath);

            fileInfo.ExtractZipFileToDirectory(destDir);

            var extractedFile = Path.Combine(destDir, _testFileName);
            Assert.True(File.Exists(extractedFile));
            Assert.Equal(_testFileContent, File.ReadAllText(extractedFile, Encoding.UTF8));
        }

        [Fact]
        public void ExtractZipFileToDirectory_StringPath_Encoding_Works()
        {
            var destDir = Path.Combine(_tempDir, "extract2");
            var fileInfo = new FileInfo(_zipFilePath);

            fileInfo.ExtractZipFileToDirectory(destDir, Encoding.UTF8);

            var extractedFile = Path.Combine(destDir, _testFileName);
            Assert.True(File.Exists(extractedFile));
            Assert.Equal(_testFileContent, File.ReadAllText(extractedFile, Encoding.UTF8));
        }

        [Fact]
        public void ExtractZipFileToDirectory_DirectoryInfo_Works()
        {
            var destDir = Path.Combine(_tempDir, "extract3");
            var dirInfo = new DirectoryInfo(destDir);
            var fileInfo = new FileInfo(_zipFilePath);

            fileInfo.ExtractZipFileToDirectory(dirInfo);

            var extractedFile = Path.Combine(destDir, _testFileName);
            Assert.True(File.Exists(extractedFile));
            Assert.Equal(_testFileContent, File.ReadAllText(extractedFile, Encoding.UTF8));
        }

        [Fact]
        public void ExtractZipFileToDirectory_DirectoryInfo_Encoding_Works()
        {
            var destDir = Path.Combine(_tempDir, "extract4");
            var dirInfo = new DirectoryInfo(destDir);
            var fileInfo = new FileInfo(_zipFilePath);

            fileInfo.ExtractZipFileToDirectory(dirInfo, Encoding.UTF8);

            var extractedFile = Path.Combine(destDir, _testFileName);
            Assert.True(File.Exists(extractedFile));
            Assert.Equal(_testFileContent, File.ReadAllText(extractedFile, Encoding.UTF8));
        }

        public void Dispose()
        {
            try
            {
                if (Directory.Exists(_tempDir))
                    Directory.Delete(_tempDir, true);
            }
            catch { }
        }
    }
}
