namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_PathCombineFileTests
    {
        [Fact]
        public void PathCombineFile_CombinesDirectoryAndFileName()
        {
            // Arrange
            var dir = new DirectoryInfo(@"C:\TestDir");
            var fileName = "file.txt";

            // Act
            var fileInfo = dir.PathCombineFile(fileName);

            // Assert
            Assert.Equal(Path.Combine(dir.FullName, fileName), fileInfo.FullName);
        }

        [Fact]
        public void PathCombineFile_CombinesMultipleSegments()
        {
            // Arrange
            var dir = new DirectoryInfo(@"C:\TestDir");
            var segments = new[] { "subdir", "file.txt" };

            // Act
            var fileInfo = dir.PathCombineFile(segments);

            // Assert
            Assert.Equal(Path.Combine(dir.FullName, "subdir", "file.txt"), fileInfo.FullName);
        }

        [Fact]
        public void PathCombineFile_WithNoAdditionalSegments_ReturnsDirectoryAsFile()
        {
            // Arrange
            var dir = new DirectoryInfo(@"C:\TestDir");

            // Act
            var fileInfo = dir.PathCombineFile();

            // Assert
            Assert.Equal(dir.FullName, fileInfo.FullName);
        }
    }
}
