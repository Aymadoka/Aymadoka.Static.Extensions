using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public class String_ToByteArrayTests
    {
        [Fact]
        public void ToByteArray_ReturnsCorrectBytes_ForAsciiString()
        {
            // Arrange
            string input = "Hello, World!";
            byte[] expected = Encoding.UTF8.GetBytes(input);

            // Act
            byte[] result = input.ToByteArray();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToByteArray_ReturnsCorrectBytes_ForUnicodeString()
        {
            // Arrange
            string input = "你好，世界！";
            byte[] expected = Encoding.UTF8.GetBytes(input);

            // Act
            byte[] result = input.ToByteArray();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToByteArray_ReturnsEmptyArray_ForEmptyString()
        {
            // Arrange
            string input = string.Empty;
            byte[] expected = Encoding.UTF8.GetBytes(input);

            // Act
            byte[] result = input.ToByteArray();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToByteArray_ThrowsArgumentNullException_ForNullString()
        {
            // Arrange
            string input = null;

            // Act & Assert
            Assert.Throws<System.ArgumentNullException>(() => input.ToByteArray());
        }
    }
}
