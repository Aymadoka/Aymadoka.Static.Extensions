using System.Security;

namespace Aymadoka.Static.StringExtension
{
    public class String_ToSecureStringTests
    {
        [Fact]
        public void ToSecureString_WithNormalString_ReturnsSecureStringWithSameContent()
        {
            // Arrange
            string input = "Test123!";

            // Act
            SecureString secure = input.ToSecureString();

            // Assert
            Assert.NotNull(secure);
            Assert.Equal(input.Length, secure.Length);
        }

        [Fact]
        public void ToSecureString_WithEmptyString_ReturnsEmptySecureString()
        {
            // Arrange
            string input = string.Empty;

            // Act
            SecureString secure = input.ToSecureString();

            // Assert
            Assert.NotNull(secure);
            Assert.Equal(0, secure.Length);
        }

        [Fact]
        public void ToSecureString_WithNull_ThrowsArgumentNullException()
        {
            // Arrange
            string input = null;

            // Act & Assert
            Assert.Throws<System.ArgumentNullException>(() => input.ToSecureString());
        }
    }
}
