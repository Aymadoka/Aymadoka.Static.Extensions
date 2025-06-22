namespace Aymadoka.Static.EncodingExtension
{
    public class Encoding_FromStringToBytesTests
    {
        [Fact]
        public void FromStringToBytes_ReturnsUtf8Bytes_ForValidString()
        {
            // Arrange
            string input = "测试Test123";
            byte[] expected = System.Text.Encoding.UTF8.GetBytes(input);

            // Act
            byte[] result = input.FromStringToBytes();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FromStringToBytes_ThrowsArgumentNullException_ForNullString()
        {
            // Arrange
            string input = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => input.FromStringToBytes());
        }

        [Fact]
        public void FromStringToBytes_ReturnsEmptyArray_ForEmptyString()
        {
            // Arrange
            string input = string.Empty;
            byte[] expected = System.Text.Encoding.UTF8.GetBytes(input);

            // Act
            byte[] result = input.FromStringToBytes();

            // Assert
            Assert.Equal(expected, result);
            Assert.Empty(result);
        }
    }
}
