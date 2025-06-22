namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_GetDirectoriesTests : IDisposable
    {
        private readonly string _rootDir;

        public DirectoryInfo_GetDirectoriesTests()
        {
            _rootDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_rootDir);
            Directory.CreateDirectory(Path.Combine(_rootDir, "data1"));
            Directory.CreateDirectory(Path.Combine(_rootDir, "data2"));
            Directory.CreateDirectory(Path.Combine(_rootDir, "test1"));
            Directory.CreateDirectory(Path.Combine(_rootDir, "test2"));
            Directory.CreateDirectory(Path.Combine(_rootDir, "other"));
            Directory.CreateDirectory(Path.Combine(_rootDir, "nested", "data3"));
        }

        [Fact]
        public void GetDirectories_WithPatterns_ReturnsMatchingDirectories()
        {
            var dirInfo = new DirectoryInfo(_rootDir);
            var patterns = new[] { "data*", "test*" };

            var result = dirInfo.GetDirectories(patterns);

            var names = result.Select(d => d.Name).ToArray();
            Assert.Contains("data1", names);
            Assert.Contains("data2", names);
            Assert.Contains("test1", names);
            Assert.Contains("test2", names);
            Assert.DoesNotContain("other", names);
            Assert.DoesNotContain("nested", names);
        }

        [Fact]
        public void GetDirectories_WithPatternsAndSearchOptionAllDirectories_ReturnsAllMatching()
        {
            var dirInfo = new DirectoryInfo(_rootDir);
            var patterns = new[] { "data*" };

            var result = dirInfo.GetDirectories(patterns, SearchOption.AllDirectories);

            var names = result.Select(d => d.Name).ToArray();
            Assert.Contains("data1", names);
            Assert.Contains("data2", names);
            Assert.Contains("data3", names);
        }

        [Fact]
        public void GetDirectories_WithEmptyPatterns_ReturnsEmpty()
        {
            var dirInfo = new DirectoryInfo(_rootDir);
            var patterns = Array.Empty<string>();

            var result = dirInfo.GetDirectories(patterns);

            Assert.Empty(result);
        }

        [Fact]
        public void GetDirectories_WithNoMatches_ReturnsEmpty()
        {
            var dirInfo = new DirectoryInfo(_rootDir);
            var patterns = new[] { "nomatch*" };

            var result = dirInfo.GetDirectories(patterns);

            Assert.Empty(result);
        }

        public void Dispose()
        {
            if (Directory.Exists(_rootDir))
                Directory.Delete(_rootDir, true);
        }
    }
}
