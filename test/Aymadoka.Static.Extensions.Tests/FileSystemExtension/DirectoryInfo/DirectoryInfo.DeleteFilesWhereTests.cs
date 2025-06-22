namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_DeleteFilesWhereTests : IDisposable
    {
        private readonly string _testDir;

        public DirectoryInfo_DeleteFilesWhereTests()
        {
            _testDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testDir);
        }

        [Fact]
        public void DeleteFilesWhere_DeletesMatchingFilesInCurrentDirectory()
        {
            // Arrange
            var dir = new DirectoryInfo(_testDir);
            var file1 = Path.Combine(_testDir, "a.txt");
            var file2 = Path.Combine(_testDir, "b.log");
            File.WriteAllText(file1, "test");
            File.WriteAllText(file2, "test");

            // Act
            dir.DeleteFilesWhere(f => f.Extension == ".txt");

            // Assert
            Assert.False(File.Exists(file1));
            Assert.True(File.Exists(file2));
        }

        [Fact]
        public void DeleteFilesWhere_WithSearchOption_DeletesMatchingFilesRecursively()
        {
            // Arrange
            var dir = new DirectoryInfo(_testDir);
            var subDirPath = Path.Combine(_testDir, "sub");
            Directory.CreateDirectory(subDirPath);
            var file1 = Path.Combine(_testDir, "a.txt");
            var file2 = Path.Combine(subDirPath, "b.txt");
            var file3 = Path.Combine(subDirPath, "c.log");
            File.WriteAllText(file1, "test");
            File.WriteAllText(file2, "test");
            File.WriteAllText(file3, "test");

            // Act
            dir.DeleteFilesWhere(SearchOption.AllDirectories, f => f.Extension == ".txt");

            // Assert
            Assert.False(File.Exists(file1));
            Assert.False(File.Exists(file2));
            Assert.True(File.Exists(file3));
        }

        public void Dispose()
        {
            if (Directory.Exists(_testDir))
            {
                Directory.Delete(_testDir, true);
            }
        }
    }
}
