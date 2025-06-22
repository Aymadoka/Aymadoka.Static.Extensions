namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_DeleteTests : IDisposable
    {
        private readonly List<string> _tempDirs = new List<string>();

        private DirectoryInfo CreateTempDirectory()
        {
            string dir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(dir);
            _tempDirs.Add(dir);
            return new DirectoryInfo(dir);
        }

        [Fact]
        public void Delete_ShouldDeleteAllDirectories()
        {
            // Arrange
            var dirs = new List<DirectoryInfo>
            {
                CreateTempDirectory(),
                CreateTempDirectory(),
                CreateTempDirectory()
            };

            // Act
            dirs.Delete();

            // Assert
            foreach (var dir in dirs)
            {
                Assert.False(dir.Exists);
            }
        }

        [Fact]
        public void Delete_EmptyCollection_DoesNotThrow()
        {
            // Arrange
            var dirs = new List<DirectoryInfo>();

            // Act & Assert
            dirs.Delete();
        }

        public void Dispose()
        {
            // Cleanup in case test failed and directories were not deleted
            foreach (var dir in _tempDirs)
            {
                if (Directory.Exists(dir))
                {
                    Directory.Delete(dir, true);
                }
            }
        }
    }
}
