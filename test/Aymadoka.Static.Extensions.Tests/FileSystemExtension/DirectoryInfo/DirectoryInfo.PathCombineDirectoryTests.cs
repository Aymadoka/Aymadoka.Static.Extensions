namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_PathCombineDirectoryTests
    {
        [Fact]
        public void PathCombineDirectory_CombinesPathsCorrectly()
        {
            // Arrange
            var baseDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
            string[] paths = { "sub1", "sub2", "sub3" };
            string expected = Path.Combine(baseDir.FullName, "sub1", "sub2", "sub3");

            // Act
            var result = baseDir.PathCombineDirectory(paths);

            // Assert
            Assert.Equal(expected, result.FullName);
        }

        [Fact]
        public void PathCombineDirectory_WithNoAdditionalPaths_ReturnsSameDirectory()
        {
            // Arrange
            var baseDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));

            // Act
            var result = baseDir.PathCombineDirectory();

            // Assert
            Assert.Equal(baseDir.FullName, result.FullName);
        }

        [Fact]
        public void PathCombineDirectory_WithNullPaths_ThrowsArgumentNullException()
        {
            // Arrange
            var baseDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => baseDir.PathCombineDirectory(null));
        }
    }
}
