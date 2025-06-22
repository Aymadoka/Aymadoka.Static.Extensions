namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_EnumerateFileSystemEntriesTests : IDisposable
    {
        private readonly string _testRoot;
        private readonly System.IO.DirectoryInfo _testDir;

        public DirectoryInfo_EnumerateFileSystemEntriesTests()
        {
            _testRoot = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testRoot);
            _testDir = new System.IO.DirectoryInfo(_testRoot);

            // 创建测试文件和目录
            File.WriteAllText(Path.Combine(_testRoot, "file1.txt"), "test1");
            File.WriteAllText(Path.Combine(_testRoot, "file2.log"), "test2");
            Directory.CreateDirectory(Path.Combine(_testRoot, "subdir1"));
            File.WriteAllText(Path.Combine(_testRoot, "subdir1", "file3.txt"), "test3");
            Directory.CreateDirectory(Path.Combine(_testRoot, "subdir2"));
        }

        [Fact]
        public void EnumerateFileSystemEntries_NoArgs_ReturnsAllEntries()
        {
            var entries = _testDir.EnumerateFileSystemEntries().ToArray();
            Assert.Contains(Path.Combine(_testRoot, "file1.txt"), entries);
            Assert.Contains(Path.Combine(_testRoot, "file2.log"), entries);
            Assert.Contains(Path.Combine(_testRoot, "subdir1"), entries);
            Assert.Contains(Path.Combine(_testRoot, "subdir2"), entries);
        }

        [Fact]
        public void EnumerateFileSystemEntries_WithSearchPattern_ReturnsMatchingEntries()
        {
            var entries = _testDir.EnumerateFileSystemEntries("*.txt").ToArray();
            Assert.Contains(Path.Combine(_testRoot, "file1.txt"), entries);
            Assert.DoesNotContain(Path.Combine(_testRoot, "file2.log"), entries);
        }

        [Fact]
        public void EnumerateFileSystemEntries_WithSearchPatternAndOption_ReturnsRecursiveEntries()
        {
            var entries = _testDir.EnumerateFileSystemEntries("*.txt", SearchOption.AllDirectories).ToArray();
            Assert.Contains(Path.Combine(_testRoot, "file1.txt"), entries);
            Assert.Contains(Path.Combine(_testRoot, "subdir1", "file3.txt"), entries);
        }

        [Fact]
        public void EnumerateFileSystemEntries_WithMultiplePatterns_ReturnsAllMatchingEntries()
        {
            var patterns = new[] { "*.txt", "*.log" };
            var entries = _testDir.EnumerateFileSystemEntries(patterns).ToArray();
            Assert.Contains(Path.Combine(_testRoot, "file1.txt"), entries);
            Assert.Contains(Path.Combine(_testRoot, "file2.log"), entries);
        }

        [Fact]
        public void EnumerateFileSystemEntries_WithMultiplePatternsAndOption_ReturnsAllRecursiveMatchingEntries()
        {
            var patterns = new[] { "*.txt", "*.log" };
            var entries = _testDir.EnumerateFileSystemEntries(patterns, SearchOption.AllDirectories).ToArray();
            Assert.Contains(Path.Combine(_testRoot, "file1.txt"), entries);
            Assert.Contains(Path.Combine(_testRoot, "file2.log"), entries);
            Assert.Contains(Path.Combine(_testRoot, "subdir1", "file3.txt"), entries);
        }

        public void Dispose()
        {
            if (Directory.Exists(_testRoot))
                Directory.Delete(_testRoot, true);
        }
    }
}
