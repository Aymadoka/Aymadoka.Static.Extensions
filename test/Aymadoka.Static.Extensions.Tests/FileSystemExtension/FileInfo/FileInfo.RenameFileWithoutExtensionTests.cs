namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_RenameFileWithoutExtensionTests : IDisposable
    {
        private readonly string _testDirectory;

        public FileInfo_RenameFileWithoutExtensionTests()
        {
            _testDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testDirectory);
        }

        [Fact]
        public void RenameFileWithoutExtension_ShouldRenameFile_KeepExtension()
        {
            // Arrange
            string originalName = "testfile.txt";
            string newName = "renamedfile";
            string originalPath = Path.Combine(_testDirectory, originalName);
            File.WriteAllText(originalPath, "test content");
            var fileInfo = new FileInfo(originalPath);

            // Act
            fileInfo.RenameFileWithoutExtension(newName);

            // Assert
            string expectedPath = Path.Combine(_testDirectory, newName + ".txt");
            Assert.False(File.Exists(originalPath));
            Assert.True(File.Exists(expectedPath));
            Assert.Equal("test content", File.ReadAllText(expectedPath));
        }

        [Fact]
        public void RenameFileWithoutExtension_ShouldThrow_WhenFileDoesNotExist()
        {
            // Arrange
            string originalPath = Path.Combine(_testDirectory, "nofile.txt");
            var fileInfo = new FileInfo(originalPath);

            // Act & Assert
            Assert.Throws<FileNotFoundException>(() => fileInfo.RenameFileWithoutExtension("newname"));
        }

        [Fact]
        public void RenameFileWithoutExtension_ShouldThrow_WhenTargetExists()
        {
            // Arrange
            string originalName = "file1.txt";
            string targetName = "file2.txt";
            string originalPath = Path.Combine(_testDirectory, originalName);
            string targetPath = Path.Combine(_testDirectory, targetName);
            File.WriteAllText(originalPath, "file1");
            File.WriteAllText(targetPath, "file2");
            var fileInfo = new FileInfo(originalPath);

            // Act & Assert
            Assert.Throws<IOException>(() => fileInfo.RenameFileWithoutExtension("file2"));
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
