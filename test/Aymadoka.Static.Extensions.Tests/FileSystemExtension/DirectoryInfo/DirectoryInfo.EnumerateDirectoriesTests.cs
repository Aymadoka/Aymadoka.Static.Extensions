namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_EnumerateDirectoriesTests : IDisposable
    {
        private readonly string _rootDir;

        public DirectoryInfo_EnumerateDirectoriesTests()
        {
            _rootDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_rootDir);
            Directory.CreateDirectory(Path.Combine(_rootDir, "Sub1"));
            Directory.CreateDirectory(Path.Combine(_rootDir, "Sub2"));
            Directory.CreateDirectory(Path.Combine(_rootDir, "TestA"));
            Directory.CreateDirectory(Path.Combine(_rootDir, "TestB"));
        }

        [Fact]
        public void EnumerateDirectories_WithMultiplePatterns_ReturnsUnionOfMatches()
        {
            var dir = new System.IO.DirectoryInfo(_rootDir);
            var result = dir.EnumerateDirectories(new[] { "Sub*", "TestA" }).Select(d => d.Name).ToList();
            Assert.Contains("Sub1", result);
            Assert.Contains("Sub2", result);
            Assert.Contains("TestA", result);
            Assert.DoesNotContain("TestB", result);
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void EnumerateDirectories_WithMultiplePatternsAndOption_ReturnsUnionOfMatches()
        {
            var subDir = Path.Combine(_rootDir, "TestA", "NestedA");
            Directory.CreateDirectory(subDir);
            var dir = new System.IO.DirectoryInfo(_rootDir);
            var result = dir.EnumerateDirectories(new[] { "NestedA", "TestB" }, SearchOption.AllDirectories)
                .Select(d => d.Name).ToList();
            Assert.Contains("NestedA", result);
            Assert.Contains("TestB", result);
            Assert.Equal(2, result.Count);
        }

        public void Dispose()
        {
            if (Directory.Exists(_rootDir))
            {
                Directory.Delete(_rootDir, true);
            }
        }
    }
}
