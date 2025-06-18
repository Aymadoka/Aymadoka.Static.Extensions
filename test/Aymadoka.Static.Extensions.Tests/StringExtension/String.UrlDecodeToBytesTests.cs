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
        public void UrlDecodeToBytes_WithEncoding_ReturnsExpectedBytes()
        {
            // Arrange
            string urlEncoded = "%C4%E3%BA%C3"; // "你好" in GB2312 URL encoding
            Encoding gb2312 = Encoding.GetEncoding("GB2312");
            byte[] expected = gb2312.GetBytes("你好");

            // Act
            byte[] actual = urlEncoded.UrlDecodeToBytes(gb2312);

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

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => urlEncoded.UrlDecodeToBytes());
        }

        [Fact]
        public void UrlDecodeToBytes_NullStringWithEncoding_ThrowsArgumentNullException()
        {
            // Arrange
            string urlEncoded = null;
            Encoding encoding = Encoding.UTF8;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => urlEncoded.UrlDecodeToBytes(encoding));
        }
    }
}
