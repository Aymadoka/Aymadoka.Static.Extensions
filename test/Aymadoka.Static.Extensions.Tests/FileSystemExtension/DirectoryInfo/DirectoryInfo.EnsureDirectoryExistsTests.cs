namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_EnsureDirectoryExistsTests : IDisposable
    {
        private readonly string _testDirPath;

        public DirectoryInfo_EnsureDirectoryExistsTests()
        {
            _testDirPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
        }

        [Fact]
        public void EnsureDirectoryExists_DirectoryDoesNotExist_CreatesDirectory()
        {
            var dirInfo = new System.IO.DirectoryInfo(_testDirPath);
            Assert.False(dirInfo.Exists);

            var result = dirInfo.EnsureDirectoryExists();

            Assert.True(result.Exists);
            Assert.Equal(_testDirPath, result.FullName);
        }

        [Fact]
        public void EnsureDirectoryExists_DirectoryAlreadyExists_ReturnsDirectoryInfo()
        {
            Directory.CreateDirectory(_testDirPath);
            var dirInfo = new System.IO.DirectoryInfo(_testDirPath);

            var result = dirInfo.EnsureDirectoryExists();

            Assert.True(result.Exists);
            Assert.Equal(_testDirPath, result.FullName);
        }

        public void Dispose()
        {
            if (Directory.Exists(_testDirPath))
            {
                Directory.Delete(_testDirPath, true);
            }
        }
    }
}
