using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_AppendAllLinesTests : IDisposable
    {
        private readonly string _testFilePath;
        private readonly FileInfo _testFileInfo;

        public FileInfo_AppendAllLinesTests()
        {
            _testFilePath = Path.GetTempFileName();
            _testFileInfo = new FileInfo(_testFilePath);
        }

        [Fact]
        public void AppendAllLines_AppendsLinesWithDefaultEncoding()
        {
            var lines1 = new[] { "Line1", "Line2" };
            var lines2 = new[] { "Line3", "Line4" };

            _testFileInfo.AppendAllLines(lines1);
            _testFileInfo.AppendAllLines(lines2);

            var allLines = File.ReadAllLines(_testFilePath);
            Assert.Equal(new[] { "Line1", "Line2", "Line3", "Line4" }, allLines);
        }

        [Fact]
        public void AppendAllLines_AppendsLinesWithSpecifiedEncoding()
        {
            var lines = new[] { "编码测试1", "编码测试2" };
            var encoding = Encoding.UTF8;

            _testFileInfo.AppendAllLines(lines, encoding);

            var readLines = File.ReadAllLines(_testFilePath, encoding);
            Assert.Equal(lines, readLines);
        }

        [Fact]
        public void AppendAllLines_EmptyLines_DoesNotThrow()
        {
            var lines = Array.Empty<string>();
            _testFileInfo.AppendAllLines(lines);
            var allLines = File.ReadAllLines(_testFilePath);
            Assert.Empty(allLines);
        }

        public void Dispose()
        {
            if (File.Exists(_testFilePath))
                File.Delete(_testFilePath);
        }
    }
}
