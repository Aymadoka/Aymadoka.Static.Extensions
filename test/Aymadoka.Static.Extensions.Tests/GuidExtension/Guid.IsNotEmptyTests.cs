namespace Aymadoka.Static.GuidExtension
{
    public class Guid_IsNotEmptyTests
    {
        [Fact]
        public void IsNotEmpty_WithEmptyGuid_ReturnsFalse()
        {
            // Arrange
            var guid = Guid.Empty;

            // Act
            var result = guid.IsNotEmpty();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNotEmpty_WithNonEmptyGuid_ReturnsTrue()
        {
            // Arrange
            var guid = Guid.NewGuid();

            // Act
            var result = guid.IsNotEmpty();

            // Assert
            Assert.True(result);
        }
    }
}
