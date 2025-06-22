namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_CountLinesTests : IDisposable
    {
        private readonly string _testFilePath;

        public FileInfo_CountLinesTests()
        {
            _testFilePath = Path.GetTempFileName();
        }

        [Fact]
        public void CountLines_ReturnsTotalLineCount()
        {
            File.WriteAllLines(_testFilePath, new[] { "line1", "line2", "line3" });
            var fileInfo = new System.IO.FileInfo(_testFilePath);

            int count = fileInfo.CountLines();

            Assert.Equal(3, count);
        }

        [Fact]
        public void CountLines_WithPredicate_ReturnsMatchingLineCount()
        {
            File.WriteAllLines(_testFilePath, new[] { "abc", "def", "abc", "xyz" });
            var fileInfo = new System.IO.FileInfo(_testFilePath);

            int count = fileInfo.CountLines(line => line == "abc");

            Assert.Equal(2, count);
        }

        [Fact]
        public void CountLines_EmptyFile_ReturnsZero()
        {
            File.WriteAllText(_testFilePath, string.Empty);
            var fileInfo = new System.IO.FileInfo(_testFilePath);

            int count = fileInfo.CountLines();

            Assert.Equal(0, count);
        }

        public void Dispose()
        {
            if (File.Exists(_testFilePath))
                File.Delete(_testFilePath);
        }
    }
}
