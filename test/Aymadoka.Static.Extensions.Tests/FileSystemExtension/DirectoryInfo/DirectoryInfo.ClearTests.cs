namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_ClearTests : IDisposable
    {
        private readonly string _testDirPath;

        public DirectoryInfo_ClearTests()
        {
            _testDirPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testDirPath);
        }

        [Fact]
        public void Clear_RemovesAllFilesAndDirectories()
        {
            // Arrange
            var dir = new DirectoryInfo(_testDirPath);
            // 创建文件
            File.WriteAllText(Path.Combine(_testDirPath, "file1.txt"), "test");
            File.WriteAllText(Path.Combine(_testDirPath, "file2.txt"), "test");
            // 创建子目录和文件
            var subDir = Directory.CreateDirectory(Path.Combine(_testDirPath, "subdir"));
            File.WriteAllText(Path.Combine(subDir.FullName, "file3.txt"), "test");

            // Act
            dir.Clear();

            // Assert
            Assert.Empty(dir.GetFiles());
            Assert.Empty(dir.GetDirectories());
        }

        [Fact]
        public void Clear_OnEmptyDirectory_DoesNotThrow()
        {
            // Arrange
            var dir = new DirectoryInfo(_testDirPath);

            // Act & Assert
            var ex = Record.Exception(() => dir.Clear());
            Assert.Null(ex);
            Assert.Empty(dir.GetFiles());
            Assert.Empty(dir.GetDirectories());
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
