namespace Aymadoka.Static.StringExtension
{
    public class String_ToFileInfoTests
    {
        [Fact]
        public void ToFileInfo_ValidPath_ReturnsFileInfoInstance()
        {
            // Arrange
            string path = "testfile.txt";

            // Act
            FileInfo fileInfo = path.ToFileInfo();

            // Assert
            Assert.NotNull(fileInfo);
            Assert.Equal(path, fileInfo.Name);
        }

        [Fact]
        public void ToFileInfo_EmptyString_ReturnsFileInfoWithEmptyName()
        {
            // Arrange
            string path = "";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => path.ToFileInfo());
        }

        [Fact]
        public void ToFileInfo_NullString_ThrowsArgumentNullException()
        {
            // Arrange
            string path = null;

            // Act & Assert
            Assert.Throws<System.ArgumentNullException>(() => path.ToFileInfo());
        }
    }
}
