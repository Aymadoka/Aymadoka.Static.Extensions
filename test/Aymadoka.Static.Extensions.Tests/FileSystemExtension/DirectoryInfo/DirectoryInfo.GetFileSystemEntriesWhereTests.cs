namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_GetFileSystemEntriesWhereTests : IDisposable
    {
        private readonly string _testDir;

        public DirectoryInfo_GetFileSystemEntriesWhereTests()
        {
            _testDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testDir);
            File.WriteAllText(Path.Combine(_testDir, "a.txt"), "test");
            File.WriteAllText(Path.Combine(_testDir, "b.log"), "test");
            File.WriteAllText(Path.Combine(_testDir, "c.txt"), "test");
            Directory.CreateDirectory(Path.Combine(_testDir, "subdir"));
            File.WriteAllText(Path.Combine(_testDir, "subdir", "d.txt"), "test");
        }

        [Fact]
        public void GetFileSystemEntriesWhere_NoPattern_FiltersCorrectly()
        {
            var dir = new System.IO.DirectoryInfo(_testDir);
            var result = dir.GetFileSystemEntriesWhere(x => x.EndsWith(".txt"));
            Assert.Contains(result, x => x.EndsWith("a.txt"));
            Assert.Contains(result, x => x.EndsWith("c.txt"));
            Assert.DoesNotContain(result, x => x.EndsWith("b.log"));
        }

        [Fact]
        public void GetFileSystemEntriesWhere_WithPattern_FiltersCorrectly()
        {
            var dir = new System.IO.DirectoryInfo(_testDir);
            var result = dir.GetFileSystemEntriesWhere("*.log", x => x.EndsWith(".log"));
            Assert.Single(result);
            Assert.Contains(result, x => x.EndsWith("b.log"));
        }

        [Fact]
        public void GetFileSystemEntriesWhere_WithPatternAndOption_FiltersCorrectly()
        {
            var dir = new System.IO.DirectoryInfo(_testDir);
            var result = dir.GetFileSystemEntriesWhere("*.txt", SearchOption.AllDirectories, x => x.EndsWith(".txt"));
            Assert.Contains(result, x => x.EndsWith("a.txt"));
            Assert.Contains(result, x => x.EndsWith("c.txt"));
            Assert.Contains(result, x => x.EndsWith("d.txt"));
        }

        [Fact]
        public void GetFileSystemEntriesWhere_WithMultiplePatterns_FiltersCorrectly()
        {
            var dir = new System.IO.DirectoryInfo(_testDir);
            var result = dir.GetFileSystemEntriesWhere(new[] { "*.txt", "*.log" }, x => x.Contains("a.") || x.Contains("b."));
            Assert.Contains(result, x => x.EndsWith("a.txt"));
            Assert.Contains(result, x => x.EndsWith("b.log"));
            Assert.DoesNotContain(result, x => x.EndsWith("c.txt"));
        }

        [Fact]
        public void GetFileSystemEntriesWhere_WithMultiplePatternsAndOption_FiltersCorrectly()
        {
            var dir = new System.IO.DirectoryInfo(_testDir);
            var result = dir.GetFileSystemEntriesWhere(new[] { "*.txt", "*.log" }, SearchOption.AllDirectories, x => x.EndsWith(".txt"));
            Assert.Contains(result, x => x.EndsWith("a.txt"));
            Assert.Contains(result, x => x.EndsWith("c.txt"));
            Assert.Contains(result, x => x.EndsWith("d.txt"));
            Assert.DoesNotContain(result, x => x.EndsWith("b.log"));
        }

        public void Dispose()
        {
            if (Directory.Exists(_testDir))
                Directory.Delete(_testDir, true);
        }
    }
}
