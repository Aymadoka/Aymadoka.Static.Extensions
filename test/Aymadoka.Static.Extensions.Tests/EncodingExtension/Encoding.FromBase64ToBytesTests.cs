namespace Aymadoka.Static.EncodingExtension
{
    public class Encoding_FromBase64ToBytesTests
    {
        [Fact]
        public void FromBase64ToBytes_ValidBase64_ReturnsExpectedBytes()
        {
            // Arrange
            var original = new byte[] { 1, 2, 3, 4, 5 };
            var base64 = Convert.ToBase64String(original);

            // Act
            var result = base64.FromBase64ToBytes();

            // Assert
            Assert.Equal(original, result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void FromBase64ToBytes_NullOrEmpty_ThrowsArgumentNullException(string input)
        {
            Assert.Throws<ArgumentNullException>(() => input.FromBase64ToBytes());
        }

        [Fact]
        public void FromBase64ToBytes_InvalidBase64_ThrowsFormatException()
        {
            // Arrange
            var invalidBase64 = "not_base64!";

            // Act & Assert
            Assert.Throws<FormatException>(() => invalidBase64.FromBase64ToBytes());
        }
    }
}
