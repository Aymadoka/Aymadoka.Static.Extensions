namespace Aymadoka.Static.StringExtension
{
    public class String_ToDirectoryInfoTests
    {
        [Fact]
        public void ToDirectoryInfo_ValidPath_ReturnsDirectoryInfo()
        {
            // Arrange
            string path = "C:\\TestDirectory";

            // Act
            DirectoryInfo dirInfo = path.ToDirectoryInfo();

            // Assert
            Assert.NotNull(dirInfo);
            Assert.Equal(path, dirInfo.FullName);
        }

        [Fact]
        public void ToDirectoryInfo_NullString_ThrowsArgumentNullException()
        {
            // Arrange
            string path = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => path.ToDirectoryInfo());
        }

        [Fact]
        public void ToDirectoryInfo_EmptyString_ReturnsDirectoryInfoWithEmptyPath()
        {
            // Arrange
            string path = string.Empty;

            // Act & Assert
            Assert.Throws<ArgumentException>(() =>
            {
                DirectoryInfo dirInfo = path.ToDirectoryInfo();
            });
        }
    }
}
