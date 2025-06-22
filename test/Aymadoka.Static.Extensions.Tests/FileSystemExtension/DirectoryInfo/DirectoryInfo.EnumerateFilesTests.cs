namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_EnumerateFilesTests : IDisposable
    {
        private readonly string _testDir;
        private readonly DirectoryInfo _dirInfo;

        public DirectoryInfo_EnumerateFilesTests()
        {
            _testDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testDir);
            _dirInfo = new DirectoryInfo(_testDir);
        }

        [Fact]
        public void EnumerateFiles_WithMultiplePatterns_ReturnsAllMatchingFiles()
        {
            File.WriteAllText(Path.Combine(_testDir, "a.txt"), "test1");
            File.WriteAllText(Path.Combine(_testDir, "b.doc"), "test2");
            File.WriteAllText(Path.Combine(_testDir, "c.md"), "test3");

            var files = _dirInfo.EnumerateFiles(new[] { "*.txt", "*.doc" }).ToList();

            Assert.Equal(2, files.Count);
            Assert.Contains(files, f => f.Name == "a.txt");
            Assert.Contains(files, f => f.Name == "b.doc");
        }

        [Fact]
        public void EnumerateFiles_WithMultiplePatternsAndOption_ReturnsAllMatchingFilesRecursively()
        {
            var subDir = Path.Combine(_testDir, "sub");
            Directory.CreateDirectory(subDir);
            File.WriteAllText(Path.Combine(_testDir, "a.txt"), "test1");
            File.WriteAllText(Path.Combine(subDir, "b.doc"), "test2");

            var files = _dirInfo.EnumerateFiles(new[] { "*.txt", "*.doc" }, SearchOption.AllDirectories).ToList();

            Assert.Equal(2, files.Count);
            Assert.Contains(files, f => f.Name == "a.txt");
            Assert.Contains(files, f => f.Name == "b.doc");
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
