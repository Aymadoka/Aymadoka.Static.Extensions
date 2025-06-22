namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_GetFilesTests : IDisposable
    {
        private readonly string _testDir;

        public DirectoryInfo_GetFilesTests()
        {
            _testDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testDir);
        }

        [Fact]
        public void GetFiles_WithMultiplePatterns_ReturnsAllMatchingFiles_Distinct()
        {
            // Arrange
            var dir = new DirectoryInfo(_testDir);
            var file1 = Path.Combine(_testDir, "a.txt");
            var file2 = Path.Combine(_testDir, "b.jpg");
            var file3 = Path.Combine(_testDir, "c.txt");
            File.WriteAllText(file1, "test1");
            File.WriteAllText(file2, "test2");
            File.WriteAllText(file3, "test3");

            // Act
            var result = dir.GetFiles(new[] { "*.txt", "*.jpg" });

            // Assert
            var fileNames = result.Select(f => f.Name).ToArray();
            Assert.Contains("a.txt", fileNames);
            Assert.Contains("b.jpg", fileNames);
            Assert.Contains("c.txt", fileNames);
            Assert.Equal(3, result.Length);
        }

        [Fact]
        public void GetFiles_WithSearchOption_AllDirectories()
        {
            // Arrange
            var subDir = Path.Combine(_testDir, "sub");
            Directory.CreateDirectory(subDir);
            var file1 = Path.Combine(_testDir, "a.txt");
            var file2 = Path.Combine(subDir, "b.txt");
            File.WriteAllText(file1, "test1");
            File.WriteAllText(file2, "test2");

            var dir = new DirectoryInfo(_testDir);

            // Act
            var result = dir.GetFiles(new[] { "*.txt" }, SearchOption.AllDirectories);

            // Assert
            var fileNames = result.Select(f => f.Name).ToArray();
            Assert.Contains("a.txt", fileNames);
            Assert.Contains("b.txt", fileNames);
            Assert.Equal(2, result.Length);
        }

        [Fact]
        public void GetFiles_DuplicateFilesAcrossPatterns_ReturnsDistinct()
        {
            // Arrange
            var filePath = Path.Combine(_testDir, "a.txt");
            File.WriteAllText(filePath, "test");
            var dir = new DirectoryInfo(_testDir);

            // Act
            var result = dir.GetFiles(new[] { "*.txt", "a.*" });

            // Assert
            Assert.Equal("a.txt", result[0].Name);
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
