using System.Text;

namespace Aymadoka.Static.StringExtension
{
    public class String_UrlDecodeToBytesTests
    {
        [Fact]
        public void UrlDecodeToBytes_DefaultEncoding_ReturnsExpectedBytes()
        {
            // Arrange
            string urlEncoded = "%E4%BD%A0%E5%A5%BD"; // "你好" in UTF-8 URL encoding
            byte[] expected = Encoding.UTF8.GetBytes("你好");

            // Act
            byte[] actual = urlEncoded.UrlDecodeToBytes();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UrlDecodeToBytes_EmptyString_ReturnsEmptyArray()
        {
            // Arrange
            string urlEncoded = string.Empty;

            // Act
            byte[] actual = urlEncoded.UrlDecodeToBytes();

            // Assert
            Assert.Empty(actual);
        }

        [Fact]
        public void UrlDecodeToBytes_NullString_ThrowsArgumentNullException()
        {
            // Arrange
            string urlEncoded = null;

            // Act
            var actual = urlEncoded.UrlDecodeToBytes();

            // Assert
            Assert.Equal(null, actual);
        }

        [Fact]
        public void UrlDecodeToBytes_NullStringWithEncoding_ThrowsArgumentNullException()
        {
            // Arrange
            string urlEncoded = null;
            Encoding encoding = Encoding.UTF8;

            var actual = urlEncoded.UrlDecodeToBytes(encoding);

            // Assert
            Assert.Equal(null, actual);
        }
    }
}
