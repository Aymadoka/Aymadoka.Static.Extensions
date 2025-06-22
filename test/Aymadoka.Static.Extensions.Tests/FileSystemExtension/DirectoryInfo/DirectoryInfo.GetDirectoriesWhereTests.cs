namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_GetDirectoriesWhereTests : IDisposable
    {
        private readonly string _rootDir;

        public DirectoryInfo_GetDirectoriesWhereTests()
        {
            _rootDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_rootDir);
            Directory.CreateDirectory(Path.Combine(_rootDir, "Alpha"));
            Directory.CreateDirectory(Path.Combine(_rootDir, "Beta"));
            Directory.CreateDirectory(Path.Combine(_rootDir, "Gamma"));
            Directory.CreateDirectory(Path.Combine(_rootDir, "Alpha", "Sub1"));
            Directory.CreateDirectory(Path.Combine(_rootDir, "Beta", "Sub2"));
        }

        [Fact]
        public void GetDirectoriesWhere_BasicPredicate_Works()
        {
            var dir = new DirectoryInfo(_rootDir);
            var result = dir.GetDirectoriesWhere(d => d.Name.StartsWith("A"));
            Assert.Single(result);
            Assert.Equal("Alpha", result[0].Name);
        }

        [Fact]
        public void GetDirectoriesWhere_WithSearchPattern_Works()
        {
            var dir = new DirectoryInfo(_rootDir);
            var result = dir.GetDirectoriesWhere("B*", d => d.Name.Length == 4);
            Assert.Single(result);
            Assert.Equal("Beta", result[0].Name);
        }

        [Fact]
        public void GetDirectoriesWhere_WithSearchPatternAndOption_Works()
        {
            var dir = new DirectoryInfo(_rootDir);
            var result = dir.GetDirectoriesWhere("Sub*", SearchOption.AllDirectories, d => d.Name.Contains("1"));
            Assert.Single(result);
            Assert.Equal("Sub1", result[0].Name);
        }

        [Fact]
        public void GetDirectoriesWhere_WithSearchPatterns_Works()
        {
            var dir = new DirectoryInfo(_rootDir);
            var result = dir.GetDirectoriesWhere(new[] { "Alpha", "Gamma" }, d => d.Name.Contains("a"));
            Assert.Equal(2, result.Length);
            Assert.Contains(result, d => d.Name == "Alpha");
            Assert.Contains(result, d => d.Name == "Gamma");
        }

        [Fact]
        public void GetDirectoriesWhere_WithSearchPatternsAndOption_Works()
        {
            var dir = new DirectoryInfo(_rootDir);
            var result = dir.GetDirectoriesWhere(new[] { "Sub1", "Sub2" }, SearchOption.AllDirectories, d => d.Name.StartsWith("Sub"));
            Assert.Equal(2, result.Length);
            Assert.Contains(result, d => d.Name == "Sub1");
            Assert.Contains(result, d => d.Name == "Sub2");
        }

        public void Dispose()
        {
            if (Directory.Exists(_rootDir))
                Directory.Delete(_rootDir, true);
        }
    }
}
