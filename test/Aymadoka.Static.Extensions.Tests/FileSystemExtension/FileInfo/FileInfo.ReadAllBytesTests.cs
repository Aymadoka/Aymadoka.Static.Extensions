using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_ReadAllBytesTests : IDisposable
    {
        private readonly string _tempFilePath;

        public FileInfo_ReadAllBytesTests()
        {
            _tempFilePath = Path.GetTempFileName();
        }

        [Fact]
        public void ReadAllBytes_ShouldReturnCorrectBytes()
        {
            // Arrange
            var expectedBytes = Encoding.UTF8.GetBytes("Hello, world!");
            File.WriteAllBytes(_tempFilePath, expectedBytes);
            var fileInfo = new System.IO.FileInfo(_tempFilePath);

            // Act
            var actualBytes = fileInfo.ReadAllBytes();

            // Assert
            Assert.Equal(expectedBytes, actualBytes);
        }

        [Fact]
        public void ReadAllBytes_EmptyFile_ReturnsEmptyArray()
        {
            // Arrange
            File.WriteAllBytes(_tempFilePath, Array.Empty<byte>());
            var fileInfo = new System.IO.FileInfo(_tempFilePath);

            // Act
            var actualBytes = fileInfo.ReadAllBytes();

            // Assert
            Assert.Empty(actualBytes);
        }

        [Fact]
        public void ReadAllBytes_FileDoesNotExist_ThrowsFileNotFoundException()
        {
            // Arrange
            var nonExistentFile = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            var fileInfo = new System.IO.FileInfo(nonExistentFile);

            // Act & Assert
            Assert.Throws<FileNotFoundException>(() => fileInfo.ReadAllBytes());
        }

        public void Dispose()
        {
            if (File.Exists(_tempFilePath))
            {
                File.Delete(_tempFilePath);
            }
        }
    }
}
