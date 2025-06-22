using System.Text;

namespace Aymadoka.Static.EncodingExtension
{
    public class Encoding_FromBytesToStringTests
    {
        [Fact]
        public void FromBytesToString_ValidUtf8Bytes_ReturnsExpectedString()
        {
            // Arrange
            string expected = "测试字符串123";
            byte[] bytes = Encoding.UTF8.GetBytes(expected);

            // Act
            string result = bytes.FromBytesToString();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FromBytesToString_EmptyArray_ReturnsEmptyString()
        {
            // Arrange
            byte[] bytes = Array.Empty<byte>();

            // Act
            string result = bytes.FromBytesToString();

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void FromBytesToString_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            byte[] bytes = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => bytes.FromBytesToString());
        }
    }
}
