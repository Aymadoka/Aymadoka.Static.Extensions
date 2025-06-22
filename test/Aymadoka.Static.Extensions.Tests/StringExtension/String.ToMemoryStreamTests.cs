using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public class String_ToMemoryStreamTests
    {
        [Fact]
        public void ToMemoryStream_ShouldReturnMemoryStreamWithAsciiBytes()
        {
            // Arrange
            string input = "Hello, 世界!";
            // ASCII 编码下，非 ASCII 字符会被替换为 '?'
            byte[] expectedBytes = Encoding.ASCII.GetBytes(input);

            // Act
            using Stream stream = input.ToMemoryStream();
            byte[] actualBytes = new byte[stream.Length];
            stream.Read(actualBytes, 0, actualBytes.Length);

            // Assert
            Assert.Equal(expectedBytes, actualBytes);
        }

        [Fact]
        public void ToMemoryStream_EmptyString_ReturnsEmptyStream()
        {
            // Arrange
            string input = string.Empty;

            // Act
            using Stream stream = input.ToMemoryStream();

            // Assert
            Assert.NotNull(stream);
            Assert.Equal(0, stream.Length);
        }

        [Fact]
        public void ToMemoryStream_NullString_ThrowsArgumentNullException()
        {
            // Arrange
            string input = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => input.ToMemoryStream());
        }
    }
}
