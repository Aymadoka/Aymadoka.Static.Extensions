namespace Aymadoka.Static.EncodingExtension
{
    public class Encoding_ToBase64FromStringTests
    {
        [Fact]
        public void ToBase64FromString_ValidString_ReturnsBase64()
        {
            // Arrange
            var input = "Hello, 世界!";
            var expected = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input));

            // Act
            var result = input.ToBase64FromString();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToBase64FromString_EmptyString_ThrowsArgumentNullException()
        {
            // Arrange
            string input = string.Empty;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => input.ToBase64FromString());
        }

        [Fact]
        public void ToBase64FromString_NullString_ThrowsArgumentNullException()
        {
            // Arrange
            string input = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => input.ToBase64FromString());
        }
    }
}
