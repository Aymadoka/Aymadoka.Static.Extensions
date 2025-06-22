using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_ReadAllLinesTests : IDisposable
    {
        private readonly string _testFilePath;
        private readonly FileInfo _testFileInfo;

        public FileInfo_ReadAllLinesTests()
        {
            _testFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".txt");
            _testFileInfo = new FileInfo(_testFilePath);
        }

        [Fact]
        public void ReadAllLines_DefaultEncoding_ReturnsAllLines()
        {
            var lines = new[] { "第一行", "第二行", "第三行" };
            File.WriteAllLines(_testFilePath, lines, Encoding.UTF8);

            var result = _testFileInfo.ReadAllLines();

            Assert.Equal(lines, result);
        }

        [Fact]
        public void ReadAllLines_WithEncoding_ReturnsAllLines()
        {
            var lines = new[] { "line1", "line2", "line3" };
            var encoding = Encoding.Unicode;
            File.WriteAllLines(_testFilePath, lines, encoding);

            var result = _testFileInfo.ReadAllLines(encoding);

            Assert.Equal(lines, result);
        }

        [Fact]
        public void ReadAllLines_FileNotExist_ThrowsFileNotFoundException()
        {
            var nonExistentFile = new FileInfo(_testFilePath + ".notfound");
            Assert.Throws<FileNotFoundException>(() => nonExistentFile.ReadAllLines());
        }

        public void Dispose()
        {
            if (File.Exists(_testFilePath))
            {
                File.Delete(_testFilePath);
            }
        }
    }
}
