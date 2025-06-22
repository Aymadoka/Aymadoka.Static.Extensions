namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_GetFileSystemEntriesTests : IDisposable
    {
        private readonly string _testRoot;
        private readonly DirectoryInfo _dirInfo;

        public DirectoryInfo_GetFileSystemEntriesTests()
        {
            _testRoot = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testRoot);
            _dirInfo = new DirectoryInfo(_testRoot);

            // 创建测试文件和目录
            File.WriteAllText(Path.Combine(_testRoot, "file1.txt"), "test1");
            File.WriteAllText(Path.Combine(_testRoot, "file2.log"), "test2");
            Directory.CreateDirectory(Path.Combine(_testRoot, "subdir1"));
            File.WriteAllText(Path.Combine(_testRoot, "subdir1", "file3.txt"), "test3");
            Directory.CreateDirectory(Path.Combine(_testRoot, "subdir2"));
        }

        [Fact]
        public void GetFileSystemEntries_NoArgs_ReturnsAllEntries()
        {
            var entries = _dirInfo.GetFileSystemEntries();
            Assert.Contains(Path.Combine(_testRoot, "file1.txt"), entries);
            Assert.Contains(Path.Combine(_testRoot, "file2.log"), entries);
            Assert.Contains(Path.Combine(_testRoot, "subdir1"), entries);
            Assert.Contains(Path.Combine(_testRoot, "subdir2"), entries);
            Assert.Equal(4, entries.Length);
        }

        [Fact]
        public void GetFileSystemEntries_WithSearchPattern_ReturnsMatchingEntries()
        {
            var entries = _dirInfo.GetFileSystemEntries("*.txt");
            Assert.Contains(Path.Combine(_testRoot, "file1.txt"), entries);
            Assert.DoesNotContain(Path.Combine(_testRoot, "file2.log"), entries);
            Assert.Single(entries);
        }

        [Fact]
        public void GetFileSystemEntries_WithSearchPatternAndOption_ReturnsMatchingEntriesRecursively()
        {
            var entries = _dirInfo.GetFileSystemEntries("*.txt", SearchOption.AllDirectories);
            Assert.Contains(Path.Combine(_testRoot, "file1.txt"), entries);
            Assert.Contains(Path.Combine(_testRoot, "subdir1", "file3.txt"), entries);
            Assert.Equal(2, entries.Length);
        }

        [Fact]
        public void GetFileSystemEntries_WithMultiplePatterns_ReturnsUnionOfMatches()
        {
            var entries = _dirInfo.GetFileSystemEntries(new[] { "*.txt", "*.log" });
            Assert.Contains(Path.Combine(_testRoot, "file1.txt"), entries);
            Assert.Contains(Path.Combine(_testRoot, "file2.log"), entries);
            Assert.Equal(2, entries.Length);
        }

        [Fact]
        public void GetFileSystemEntries_WithMultiplePatternsAndOption_ReturnsUnionOfMatchesRecursively()
        {
            var entries = _dirInfo.GetFileSystemEntries(new[] { "*.txt", "*.log" }, SearchOption.AllDirectories);
            Assert.Contains(Path.Combine(_testRoot, "file1.txt"), entries);
            Assert.Contains(Path.Combine(_testRoot, "file2.log"), entries);
            Assert.Contains(Path.Combine(_testRoot, "subdir1", "file3.txt"), entries);
            Assert.Equal(3, entries.Length);
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
