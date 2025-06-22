using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_ReadLinesTests : IDisposable
    {
        private readonly string _testFilePath;
        private readonly string[] _testLines = new[] { "第一行", "第二行", "第三行" };

        public FileInfo_ReadLinesTests()
        {
            _testFilePath = Path.GetTempFileName();
            File.WriteAllLines(_testFilePath, _testLines, Encoding.UTF8);
        }

        [Fact]
        public void ReadLines_DefaultEncoding_ReturnsAllLines()
        {
            var fileInfo = new System.IO.FileInfo(_testFilePath);
            var lines = fileInfo.ReadLines().ToArray();
            Assert.Equal(_testLines, lines);
        }

        [Fact]
        public void ReadLines_SpecifiedEncoding_ReturnsAllLines()
        {
            var fileInfo = new System.IO.FileInfo(_testFilePath);
            var lines = fileInfo.ReadLines(Encoding.UTF8).ToArray();
            Assert.Equal(_testLines, lines);
        }

        [Fact]
        public void ReadLines_EmptyFile_ReturnsEmpty()
        {
            var emptyFile = Path.GetTempFileName();
            var fileInfo = new System.IO.FileInfo(emptyFile);
            var lines = fileInfo.ReadLines().ToArray();
            Assert.Empty(lines);
            File.Delete(emptyFile);
        }

        public void Dispose()
        {
            if (File.Exists(_testFilePath))
                File.Delete(_testFilePath);
        }
    }
}
