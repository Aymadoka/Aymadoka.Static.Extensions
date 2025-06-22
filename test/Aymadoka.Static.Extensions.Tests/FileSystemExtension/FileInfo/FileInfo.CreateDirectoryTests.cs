namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_CreateDirectoryTests : IDisposable
    {
        private readonly string _testDirectory;

        public FileInfo_CreateDirectoryTests()
        {
            _testDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
        }

        [Fact]
        public void CreateDirectory_ShouldCreateDirectory_WhenDirectoryDoesNotExist()
        {
            // Arrange
            var filePath = Path.Combine(_testDirectory, "test.txt");
            var fileInfo = new FileInfo(filePath);

            // Act
            var dirInfo = fileInfo.CreateDirectory();

            // Assert
            Assert.True(Directory.Exists(_testDirectory));
            Assert.Equal(_testDirectory, dirInfo.FullName);
        }

        [Fact]
        public void CreateDirectory_ShouldReturnExistingDirectory_WhenDirectoryAlreadyExists()
        {
            // Arrange
            Directory.CreateDirectory(_testDirectory);
            var filePath = Path.Combine(_testDirectory, "test.txt");
            var fileInfo = new FileInfo(filePath);

            // Act
            var dirInfo = fileInfo.CreateDirectory();

            // Assert
            Assert.True(Directory.Exists(_testDirectory));
            Assert.Equal(_testDirectory, dirInfo.FullName);
        }

        public void Dispose()
        {
            if (Directory.Exists(_testDirectory))
            {
                Directory.Delete(_testDirectory, true);
            }
        }
    }
}
