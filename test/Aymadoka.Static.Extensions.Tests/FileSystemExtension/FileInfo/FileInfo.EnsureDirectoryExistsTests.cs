namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_EnsureDirectoryExistsTests
    {
        [Fact]
        public void EnsureDirectoryExists_DirectoryDoesNotExist_CreatesDirectory()
        {
            // Arrange
            var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            var filePath = Path.Combine(tempDir, "test.txt");
            var fileInfo = new FileInfo(filePath);

            // Act
            var dirInfo = fileInfo.EnsureDirectoryExists();

            // Assert
            Assert.True(Directory.Exists(tempDir));
            Assert.Equal(tempDir, dirInfo.FullName);

            // Cleanup
            Directory.Delete(tempDir, true);
        }

        [Fact]
        public void EnsureDirectoryExists_DirectoryExists_ReturnsDirectoryInfo()
        {
            // Arrange
            var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            var filePath = Path.Combine(tempDir, "test.txt");
            var fileInfo = new FileInfo(filePath);

            // Act
            var dirInfo = fileInfo.EnsureDirectoryExists();

            // Assert
            Assert.True(Directory.Exists(tempDir));
            Assert.Equal(tempDir, dirInfo.FullName);

            // Cleanup
            Directory.Delete(tempDir, true);
        }

        [Fact]
        public void EnsureDirectoryExists_NullFileInfo_ThrowsArgumentNullException()
        {
            // Arrange
            FileInfo fileInfo = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => fileInfo.EnsureDirectoryExists());
        }
    }
}
