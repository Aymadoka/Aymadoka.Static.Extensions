namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_WriteAllBytesTests : IDisposable
    {
        private readonly string _testFilePath;

        public FileInfo_WriteAllBytesTests()
        {
            _testFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".bin");
        }

        [Fact]
        public void WriteAllBytes_WritesBytesToFile()
        {
            // Arrange
            var fileInfo = new System.IO.FileInfo(_testFilePath);
            byte[] data = { 1, 2, 3, 4, 5 };

            // Act
            fileInfo.WriteAllBytes(data);

            // Assert
            Assert.True(File.Exists(_testFilePath));
            byte[] read = File.ReadAllBytes(_testFilePath);
            Assert.Equal(data, read);
        }

        [Fact]
        public void WriteAllBytes_OverwritesExistingFile()
        {
            // Arrange
            var fileInfo = new System.IO.FileInfo(_testFilePath);
            byte[] initial = { 9, 9, 9 };
            File.WriteAllBytes(_testFilePath, initial);
            byte[] newData = { 7, 8 };

            // Act
            fileInfo.WriteAllBytes(newData);

            // Assert
            byte[] read = File.ReadAllBytes(_testFilePath);
            Assert.Equal(newData, read);
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
