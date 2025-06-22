namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_RenameTests : IDisposable
    {
        private readonly string _testDirectory;

        public FileInfo_RenameTests()
        {
            _testDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testDirectory);
        }

        [Fact]
        public void Rename_ShouldRenameFile_WhenNewNameIsValid()
        {
            // Arrange
            string originalFile = Path.Combine(_testDirectory, "test.txt");
            string newFileName = "renamed.txt";
            File.WriteAllText(originalFile, "content");
            var fileInfo = new System.IO.FileInfo(originalFile);

            // Act
            fileInfo.Rename(newFileName);

            // Assert
            string newFilePath = Path.Combine(_testDirectory, newFileName);
            Assert.False(File.Exists(originalFile));
            Assert.True(File.Exists(newFilePath));
            Assert.Equal("content", File.ReadAllText(newFilePath));
        }

        [Fact]
        public void Rename_ShouldThrowIOException_WhenTargetFileExists()
        {
            // Arrange
            string originalFile = Path.Combine(_testDirectory, "test.txt");
            string newFileName = "exists.txt";
            string newFilePath = Path.Combine(_testDirectory, newFileName);
            File.WriteAllText(originalFile, "content");
            File.WriteAllText(newFilePath, "other");
            var fileInfo = new System.IO.FileInfo(originalFile);

            // Act & Assert
            Assert.Throws<IOException>(() => fileInfo.Rename(newFileName));
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
