namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_GetFilesWhereTests : IDisposable
    {
        private readonly string _testDir;

        public DirectoryInfo_GetFilesWhereTests()
        {
            _testDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testDir);
            File.WriteAllText(Path.Combine(_testDir, "a.txt"), "test1");
            File.WriteAllText(Path.Combine(_testDir, "b.txt"), "test2");
            File.WriteAllText(Path.Combine(_testDir, "c.md"), "test3");
            Directory.CreateDirectory(Path.Combine(_testDir, "sub"));
            File.WriteAllText(Path.Combine(_testDir, "sub", "d.txt"), "test4");
        }

        [Fact]
        public void GetFilesWhere_BasicPredicate_Works()
        {
            var dir = new DirectoryInfo(_testDir);
            var files = dir.GetFilesWhere(f => f.Extension == ".txt");
            Assert.Equal(2, files.Length);
            Assert.All(files, f => Assert.EndsWith(".txt", f.Name));
        }

        [Fact]
        public void GetFilesWhere_WithSearchPattern_Works()
        {
            var dir = new DirectoryInfo(_testDir);
            var files = dir.GetFilesWhere("*.md", f => f.Name.StartsWith("c"));
            Assert.Single(files);
            Assert.Equal("c.md", files[0].Name);
        }

        [Fact]
        public void GetFilesWhere_WithSearchPatternAndOption_Works()
        {
            var dir = new DirectoryInfo(_testDir);
            var files = dir.GetFilesWhere("*.txt", SearchOption.AllDirectories, f => f.Name.Contains("d"));
            Assert.Single(files);
            Assert.Equal("d.txt", files[0].Name);
        }

        [Fact]
        public void GetFilesWhere_WithMultiplePatterns_Works()
        {
            var dir = new DirectoryInfo(_testDir);
            var files = dir.GetFilesWhere(new[] { "*.txt", "*.md" }, f => f.Length > 0);
            Assert.Equal(3, files.Length);
        }

        [Fact]
        public void GetFilesWhere_WithMultiplePatternsAndOption_Works()
        {
            var dir = new DirectoryInfo(_testDir);
            var files = dir.GetFilesWhere(new[] { "*.txt", "*.md" }, SearchOption.AllDirectories, f => f.Name.Contains("t"));
            Assert.Equal(3, files.Length);
        }

        public void Dispose()
        {
            if (Directory.Exists(_testDir))
                Directory.Delete(_testDir, true);
        }
    }
}
