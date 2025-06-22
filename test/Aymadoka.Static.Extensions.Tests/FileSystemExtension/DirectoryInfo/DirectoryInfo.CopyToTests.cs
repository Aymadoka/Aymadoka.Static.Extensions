namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_CopyToTests : IDisposable
    {
        private readonly string _sourceDir;
        private readonly string _destDir;

        public DirectoryInfo_CopyToTests()
        {
            _sourceDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            _destDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_sourceDir);
        }

        [Fact]
        public void CopyTo_CopiesAllFiles_NoSubdirectories()
        {
            var file1 = Path.Combine(_sourceDir, "a.txt");
            var file2 = Path.Combine(_sourceDir, "b.txt");
            File.WriteAllText(file1, "test1");
            File.WriteAllText(file2, "test2");

            var dirInfo = new DirectoryInfo(_sourceDir);
            dirInfo.CopyTo(_destDir);

            Assert.True(File.Exists(Path.Combine(_destDir, "a.txt")));
            Assert.True(File.Exists(Path.Combine(_destDir, "b.txt")));
            Assert.Equal("test1", File.ReadAllText(Path.Combine(_destDir, "a.txt")));
            Assert.Equal("test2", File.ReadAllText(Path.Combine(_destDir, "b.txt")));
        }

        [Fact]
        public void CopyTo_WithSearchPattern_CopiesMatchingFiles()
        {
            File.WriteAllText(Path.Combine(_sourceDir, "a.txt"), "a");
            File.WriteAllText(Path.Combine(_sourceDir, "b.log"), "b");

            var dirInfo = new DirectoryInfo(_sourceDir);
            dirInfo.CopyTo(_destDir, "*.txt");

            Assert.True(File.Exists(Path.Combine(_destDir, "a.txt")));
            Assert.False(File.Exists(Path.Combine(_destDir, "b.log")));
        }

        [Fact]
        public void CopyTo_WithSearchOption_CopiesAllFilesAndDirs()
        {
            // 创建带有子目录和文件的源目录结构
            var subDir = Path.Combine(_sourceDir, "subdir");
            Directory.CreateDirectory(subDir);
            File.WriteAllText(Path.Combine(_sourceDir, "root.txt"), "root");
            File.WriteAllText(Path.Combine(subDir, "sub.txt"), "sub");
            Directory.CreateDirectory(Path.Combine(_sourceDir, "emptydir"));

            var dirInfo = new DirectoryInfo(_sourceDir);
            // 只测试 SearchOption.AllDirectories 的情况
            dirInfo.CopyTo(_destDir, SearchOption.AllDirectories);

            // 验证所有文件和空目录都被复制
            Assert.True(File.Exists(Path.Combine(_destDir, "root.txt")));
            Assert.True(File.Exists(Path.Combine(_destDir, "subdir", "sub.txt")));
            Assert.True(Directory.Exists(Path.Combine(_destDir, "emptydir")));
        }

        [Fact]
        public void CopyTo_WithSubdirectories_CopiesAllFilesAndEmptyDirs()
        {
            var subDir = Path.Combine(_sourceDir, "sub");
            Directory.CreateDirectory(subDir);
            File.WriteAllText(Path.Combine(subDir, "c.txt"), "c");
            Directory.CreateDirectory(Path.Combine(_sourceDir, "empty"));

            var dirInfo = new DirectoryInfo(_sourceDir);
            dirInfo.CopyTo(_destDir, "*.*", SearchOption.AllDirectories);

            Assert.True(File.Exists(Path.Combine(_destDir, "sub", "c.txt")));
            Assert.True(Directory.Exists(Path.Combine(_destDir, "empty")));
        }

        [Fact]
        public void CopyTo_WithSearchPatternAndSubdirectories_CopiesCorrectFilesAndDirs()
        {
            var subDir = Path.Combine(_sourceDir, "sub");
            Directory.CreateDirectory(subDir);
            File.WriteAllText(Path.Combine(_sourceDir, "a.txt"), "a");
            File.WriteAllText(Path.Combine(subDir, "b.txt"), "b");
            File.WriteAllText(Path.Combine(subDir, "c.log"), "c");

            var dirInfo = new DirectoryInfo(_sourceDir);
            dirInfo.CopyTo(_destDir, "*.txt", SearchOption.AllDirectories);

            Assert.True(File.Exists(Path.Combine(_destDir, "a.txt")));
            Assert.True(File.Exists(Path.Combine(_destDir, "sub", "b.txt")));
            Assert.False(File.Exists(Path.Combine(_destDir, "sub", "c.log")));
        }

        public void Dispose()
        {
            if (Directory.Exists(_sourceDir))
                Directory.Delete(_sourceDir, true);
            if (Directory.Exists(_destDir))
                Directory.Delete(_destDir, true);
        }
    }
}
