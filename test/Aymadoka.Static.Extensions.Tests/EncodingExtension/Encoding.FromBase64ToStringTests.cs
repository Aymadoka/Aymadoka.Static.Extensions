using System.Text;

namespace Aymadoka.Static.EncodingExtension
{
    public class Encoding_FromBase64ToStringTests
    {
        [Fact]
        public void FromBase64ToString_ValidBase64_ReturnsDecodedString()
        {
            // Arrange
            var original = "测试字符串";
            var base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(original));

            // Act
            var result = base64.FromBase64ToString();

            // Assert
            Assert.Equal(original, result);
        }

        [Fact]
        public void FromBase64ToString_NullOrEmpty_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => ((string)null).FromBase64ToString());
            Assert.Throws<ArgumentNullException>(() => string.Empty.FromBase64ToString());
        }

        [Fact]
        public void FromBase64ToString_InvalidBase64_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(() => "not_base64".FromBase64ToString());
        }

    }
}
