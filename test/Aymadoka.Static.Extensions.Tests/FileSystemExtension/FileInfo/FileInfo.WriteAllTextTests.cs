using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_WriteAllTextTests : IDisposable
    {
        private readonly string _testFilePath;
        private readonly FileInfo _testFileInfo;

        public FileInfo_WriteAllTextTests()
        {
            _testFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".txt");
            _testFileInfo = new FileInfo(_testFilePath);
        }

        [Fact]
        public void WriteAllText_ShouldWriteContent_WithDefaultEncoding()
        {
            // Arrange
            string content = "Hello, world!";

            // Act
            _testFileInfo.WriteAllText(content);

            // Assert
            string result = File.ReadAllText(_testFilePath);
            Assert.Equal(content, result);
        }

        [Fact]
        public void WriteAllText_ShouldWriteContent_WithSpecifiedEncoding()
        {
            // Arrange
            string content = "你好，世界！";
            Encoding encoding = Encoding.UTF8;

            // Act
            _testFileInfo.WriteAllText(content, encoding);

            // Assert
            string result = File.ReadAllText(_testFilePath, encoding);
            Assert.Equal(content, result);
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
