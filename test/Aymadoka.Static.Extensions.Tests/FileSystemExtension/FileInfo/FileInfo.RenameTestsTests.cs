namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_RenameTestsTests : IDisposable
    {
        private readonly string _testDirectory;

        public FileInfo_RenameTestsTests()
        {
            _testDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testDirectory);
        }

        [Fact]
        public void RenameExtension_ChangesExtension_Correctly()
        {
            // Arrange
            string originalFile = Path.Combine(_testDirectory, "testfile.txt");
            File.WriteAllText(originalFile, "test content");
            var fileInfo = new System.IO.FileInfo(originalFile);

            // Act
            fileInfo.RenameExtension(".md");

            // Assert
            string expectedFile = Path.Combine(_testDirectory, "testfile.md");
            Assert.False(File.Exists(originalFile));
            Assert.True(File.Exists(expectedFile));
            Assert.Equal("test content", File.ReadAllText(expectedFile));
        }

        [Fact]
        public void RenameExtension_WithoutDot_AddsExtension()
        {
            // Arrange
            string originalFile = Path.Combine(_testDirectory, "sample.log");
            File.WriteAllText(originalFile, "log data");
            var fileInfo = new System.IO.FileInfo(originalFile);

            // Act
            fileInfo.RenameExtension("bak");

            // Assert
            string expectedFile = Path.Combine(_testDirectory, "sample.bak");
            Assert.False(File.Exists(originalFile));
            Assert.True(File.Exists(expectedFile));
            Assert.Equal("log data", File.ReadAllText(expectedFile));
        }

        [Fact]
        public void RenameExtension_EmptyExtension_RemovesExtension()
        {
            // Arrange
            string originalFile = Path.Combine(_testDirectory, "data.csv");
            File.WriteAllText(originalFile, "csv,data");
            var fileInfo = new System.IO.FileInfo(originalFile);

            // Act
            fileInfo.RenameExtension("");

            // Assert
            string expectedFile = Path.Combine(_testDirectory, "data");
            Assert.False(File.Exists(originalFile));
            Assert.True(File.Exists(expectedFile));
            Assert.Equal("csv,data", File.ReadAllText(expectedFile));
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
