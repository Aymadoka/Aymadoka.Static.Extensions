using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_WriteAllLinesTests : IDisposable
    {
        private readonly string _testFilePath;

        public FileInfo_WriteAllLinesTests()
        {
            _testFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".txt");
        }

        [Fact]
        public void WriteAllLines_StringArray_DefaultEncoding_WritesCorrectly()
        {
            var lines = new[] { "line1", "line2", "line3" };
            var fileInfo = new System.IO.FileInfo(_testFilePath);

            fileInfo.WriteAllLines(lines);

            var readLines = File.ReadAllLines(_testFilePath);
            Assert.Equal(lines, readLines);
        }

        [Fact]
        public void WriteAllLines_StringArray_WithEncoding_WritesCorrectly()
        {
            var lines = new[] { "编码1", "编码2" };
            var encoding = Encoding.UTF8;
            var fileInfo = new System.IO.FileInfo(_testFilePath);

            fileInfo.WriteAllLines(lines, encoding);

            var readLines = File.ReadAllLines(_testFilePath, encoding);
            Assert.Equal(lines, readLines);
        }

        [Fact]
        public void WriteAllLines_IEnumerable_DefaultEncoding_WritesCorrectly()
        {
            IEnumerable<string> lines = new List<string> { "a", "b", "c" };
            var fileInfo = new System.IO.FileInfo(_testFilePath);

            fileInfo.WriteAllLines(lines);

            var readLines = File.ReadAllLines(_testFilePath);
            Assert.True(lines.SequenceEqual(readLines));
        }

        [Fact]
        public void WriteAllLines_IEnumerable_WithEncoding_WritesCorrectly()
        {
            IEnumerable<string> lines = new List<string> { "一", "二", "三" };
            var encoding = Encoding.Unicode;
            var fileInfo = new System.IO.FileInfo(_testFilePath);

            fileInfo.WriteAllLines(lines, encoding);

            var readLines = File.ReadAllLines(_testFilePath, encoding);
            Assert.True(lines.SequenceEqual(readLines));
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
