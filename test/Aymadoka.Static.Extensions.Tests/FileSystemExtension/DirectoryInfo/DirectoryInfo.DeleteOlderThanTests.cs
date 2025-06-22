namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_DeleteOlderThanTests : IDisposable
    {
        private readonly string _testRoot;

        public DirectoryInfo_DeleteOlderThanTests()
        {
            _testRoot = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testRoot);
        }

        [Fact]
        public void DeleteOlderThan_ShouldDeleteOldFilesAndDirectories_NonRecursive()
        {
            // Arrange
            var dir = new DirectoryInfo(_testRoot);
            var oldFile = dir.CreateFile("old.txt", DateTime.Now.AddHours(-2));
            var newFile = dir.CreateFile("new.txt", DateTime.Now);
            var oldSubDir = dir.CreateSubDirectory("oldsub", DateTime.Now.AddHours(-2));
            var newSubDir = dir.CreateSubDirectory("newsub", DateTime.Now);

            // Act
            dir.DeleteOlderThan(TimeSpan.FromHours(1));

            // Assert
            Assert.False(File.Exists(oldFile.FullName));
            Assert.True(File.Exists(newFile.FullName));
            Assert.False(Directory.Exists(oldSubDir.FullName));
            Assert.True(Directory.Exists(newSubDir.FullName));
        }

        [Fact]
        public void DeleteOlderThan_ShouldDeleteOldFilesAndDirectories_Recursive()
        {
            // Arrange
            var dir = new DirectoryInfo(_testRoot);
            var subDir = dir.CreateSubDirectory("sub", DateTime.Now);
            var oldFile = subDir.CreateFile("old.txt", DateTime.Now.AddHours(-2));
            var newFile = subDir.CreateFile("new.txt", DateTime.Now);
            var oldSubDir = subDir.CreateSubDirectory("oldsub", DateTime.Now.AddHours(-2));
            var newSubDir = subDir.CreateSubDirectory("newsub", DateTime.Now);

            // Act
            dir.DeleteOlderThan(SearchOption.AllDirectories, TimeSpan.FromHours(1));

            // Assert
            Assert.False(File.Exists(oldFile.FullName));
            Assert.True(File.Exists(newFile.FullName));
            Assert.False(Directory.Exists(oldSubDir.FullName));
            Assert.True(Directory.Exists(newSubDir.FullName));
        }

        public void Dispose()
        {
            if (Directory.Exists(_testRoot))
                Directory.Delete(_testRoot, true);
        }
    }

    internal static class DirectoryInfoTestExtensions
    {
        public static FileInfo CreateFile(this DirectoryInfo dir, string name, DateTime lastWriteTime)
        {
            var filePath = Path.Combine(dir.FullName, name);
            File.WriteAllText(filePath, "test");
            File.SetLastWriteTime(filePath, lastWriteTime);
            return new FileInfo(filePath);
        }

        public static DirectoryInfo CreateSubDirectory(this DirectoryInfo dir, string name, DateTime lastWriteTime)
        {
            var subDir = dir.CreateSubdirectory(name);
            Directory.SetLastWriteTime(subDir.FullName, lastWriteTime);
            return subDir;
        }
    }
}
