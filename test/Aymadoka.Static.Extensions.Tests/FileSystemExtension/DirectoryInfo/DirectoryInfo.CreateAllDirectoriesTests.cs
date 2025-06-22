namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_CreateAllDirectoriesTests : IDisposable
    {
        private readonly string _testRoot;

        public DirectoryInfo_CreateAllDirectoriesTests()
        {
            _testRoot = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
        }

        [Fact]
        public void CreateAllDirectories_CreatesNonExistentDirectories()
        {
            // Arrange
            var dirPath = Path.Combine(_testRoot, "a", "b", "c");
            var dirInfo = new System.IO.DirectoryInfo(dirPath);

            // Act
            var created = dirInfo.CreateAllDirectories();

            // Assert
            Assert.True(created.Exists);
            Assert.Equal(dirPath, created.FullName);
        }

        [Fact]
        public void CreateAllDirectories_ReturnsExistingDirectory()
        {
            // Arrange
            Directory.CreateDirectory(_testRoot);
            var dirInfo = new System.IO.DirectoryInfo(_testRoot);

            // Act
            var created = dirInfo.CreateAllDirectories();

            // Assert
            Assert.True(created.Exists);
            Assert.Equal(_testRoot, created.FullName);
        }

        public void Dispose()
        {
            if (Directory.Exists(_testRoot))
            {
                Directory.Delete(_testRoot, true);
            }
        }
    }
}
