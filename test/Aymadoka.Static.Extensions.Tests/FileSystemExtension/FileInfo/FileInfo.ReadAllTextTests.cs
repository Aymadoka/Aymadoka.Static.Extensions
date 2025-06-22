using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_ReadAllTextTests : IDisposable
    {
        private readonly string _testFilePath;
        private readonly FileInfo _testFileInfo;

        public FileInfo_ReadAllTextTests()
        {
            _testFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".txt");
            _testFileInfo = new FileInfo(_testFilePath);
        }

        [Fact]
        public void ReadAllText_ShouldReturnFileContent_WithDefaultEncoding()
        {
            var content = "Hello, 世界!";
            File.WriteAllText(_testFilePath, content, Encoding.UTF8);

            var result = _testFileInfo.ReadAllText();

            Assert.Equal(content, result);
        }

        [Fact]
        public void ReadAllText_ShouldReturnFileContent_WithSpecifiedEncoding()
        {
            var content = "你好，世界！";
            var encoding = Encoding.Unicode;
            File.WriteAllText(_testFilePath, content, encoding);

            var result = _testFileInfo.ReadAllText(encoding);

            Assert.Equal(content, result);
        }

        [Fact]
        public void ReadAllText_ShouldThrowFileNotFoundException_WhenFileDoesNotExist()
        {
            var nonExistentFile = new FileInfo(_testFilePath + ".notfound");

            Assert.Throws<FileNotFoundException>(() => nonExistentFile.ReadAllText());
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
