using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_AppendAllTextTests : IDisposable
    {
        private readonly string _testFilePath;
        private readonly FileInfo _fileInfo;

        public FileInfo_AppendAllTextTests()
        {
            _testFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".txt");
            _fileInfo = new FileInfo(_testFilePath);
        }

        [Fact]
        public void AppendAllText_AppendsText_UsingDefaultEncoding()
        {
            // Arrange
            string initial = "Hello";
            string append = " World";
            File.WriteAllText(_testFilePath, initial);

            // Act
            _fileInfo.AppendAllText(append);

            // Assert
            string result = File.ReadAllText(_testFilePath);
            Assert.Equal(initial + append, result);
        }

        [Fact]
        public void AppendAllText_AppendsText_UsingSpecifiedEncoding()
        {
            // Arrange
            string initial = "你好";
            string append = " 世界";
            Encoding encoding = Encoding.UTF8;
            File.WriteAllText(_testFilePath, initial, encoding);

            // Act
            _fileInfo.AppendAllText(append, encoding);

            // Assert
            string result = File.ReadAllText(_testFilePath, encoding);
            Assert.Equal(initial + append, result);
        }

        [Fact]
        public void AppendAllText_CreatesFileIfNotExists()
        {
            // Arrange
            string content = "TestContent";
            if (_fileInfo.Exists)
                _fileInfo.Delete();

            // Act
            _fileInfo.AppendAllText(content);

            // Assert
            Assert.False(_fileInfo.Exists);
            string result = File.ReadAllText(_testFilePath);
            Assert.Equal(content, result);
        }

        public void Dispose()
        {
            if (_fileInfo.Exists)
                _fileInfo.Delete();
        }
    }
}
