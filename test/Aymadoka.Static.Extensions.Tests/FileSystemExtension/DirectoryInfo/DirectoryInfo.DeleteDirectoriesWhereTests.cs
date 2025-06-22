namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_DeleteDirectoriesWhereTests : IDisposable
    {
        private readonly string _testRoot;

        public DirectoryInfo_DeleteDirectoriesWhereTests()
        {
            _testRoot = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(_testRoot);
        }

        [Fact]
        public void DeleteDirectoriesWhere_TopDirectoryOnly_DeletesMatchingDirectories()
        {
            // Arrange
            var root = new DirectoryInfo(_testRoot);
            var dirA = root.CreateSubdirectory("A");
            var dirB = root.CreateSubdirectory("B");
            var dirC = root.CreateSubdirectory("C");
            dirA.CreateSubdirectory("A1"); // Should not be deleted in TopDirectoryOnly

            // Act
            root.DeleteDirectoriesWhere(d => d.Name == "A" || d.Name == "B");

            // Assert
            Assert.False(Directory.Exists(dirA.FullName));
            Assert.False(Directory.Exists(dirB.FullName));
            Assert.True(Directory.Exists(dirC.FullName));
        }

        [Fact]
        public void DeleteDirectoriesWhere_AllDirectories_RecursiveDelete()
        {
            // Arrange
            var root = new DirectoryInfo(_testRoot);
            var dirA = root.CreateSubdirectory("A");
            var dirA1 = dirA.CreateSubdirectory("A1");
            var dirB = root.CreateSubdirectory("B");
            var dirB1 = dirB.CreateSubdirectory("B1");

            // Act
            root.DeleteDirectoriesWhere(SearchOption.AllDirectories, d => d.Name.EndsWith("1"));

            // Assert
            Assert.True(Directory.Exists(dirA.FullName));
            Assert.False(Directory.Exists(dirA1.FullName));
            Assert.True(Directory.Exists(dirB.FullName));
            Assert.False(Directory.Exists(dirB1.FullName));
        }

        [Fact]
        public void DeleteDirectoriesWhere_NoMatch_DoesNothing()
        {
            // Arrange
            var root = new DirectoryInfo(_testRoot);
            var dirA = root.CreateSubdirectory("A");

            // Act
            root.DeleteDirectoriesWhere(d => d.Name == "NotExist");

            // Assert
            Assert.True(Directory.Exists(dirA.FullName));
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
