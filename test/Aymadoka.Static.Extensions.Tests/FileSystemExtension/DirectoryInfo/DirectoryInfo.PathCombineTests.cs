using System.IO;

namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_PathCombineTests
    {
        [Fact]
        public void PathCombine_CombinesPathsCorrectly()
        {
            // Arrange
            var dir = new DirectoryInfo(@"C:\TestDir");
            var subPath1 = "SubFolder";
            var subPath2 = "File.txt";

            // Act
            var result = dir.PathCombine(subPath1, subPath2);

            // Assert
            Assert.Equal(Path.Combine(@"C:\TestDir", "SubFolder", "File.txt"), result);
        }

        [Fact]
        public void PathCombine_WithNoAdditionalPaths_ReturnsDirectoryFullName()
        {
            // Arrange
            var dir = new DirectoryInfo(@"C:\TestDir");

            // Act
            var result = dir.PathCombine();

            // Assert
            Assert.Equal(@"C:\TestDir", result);
        }

        [Fact]
        public void PathCombine_ThrowsArgumentNullException_WhenThisIsNull()
        {
            // Arrange
            DirectoryInfo dir = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => dir.PathCombine("subdir"));
        }

        [Fact]
        public void PathCombine_WithNullOrEmptyPaths_IgnoresThem()
        {
            // Arrange
            var dir = new DirectoryInfo(@"C:\TestDir");

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => dir.PathCombine(null, "", "SubFolder"));
        }
    }
}
