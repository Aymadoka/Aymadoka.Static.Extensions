namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_PathCombineTests
    {
        [Fact]
        public void PathCombine_CombinesMultipleSegments_ReturnsCorrectPath()
        {
            // Arrange
            var segments = new List<string> { "folder1", "folder2", "file.txt" };

            // Act
            var result = segments.PathCombine();

            // Assert
            var expected = Path.Combine("folder1", "folder2", "file.txt");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PathCombine_EmptyList_ReturnsEmptyString()
        {
            // Arrange
            var segments = new List<string>();

            // Act
            var result = segments.PathCombine();

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void PathCombine_SingleSegment_ReturnsThatSegment()
        {
            // Arrange
            var segments = new List<string> { "file.txt" };

            // Act
            var result = segments.PathCombine();

            // Assert
            Assert.Equal("file.txt", result);
        }
    }
}
