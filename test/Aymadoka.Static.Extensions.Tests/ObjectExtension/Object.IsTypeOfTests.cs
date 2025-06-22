namespace Aymadoka.Static.ObjectExtension
{
    public class Object_IsTypeOfTests
    {
        [Fact]
        public void IsTypeOf_ReturnsTrue_WhenTypeMatches()
        {
            // Arrange
            object obj = "test";
            Type type = typeof(string);

            // Act
            bool result = obj.IsTypeOf(type);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsTypeOf_ReturnsFalse_WhenTypeDoesNotMatch()
        {
            // Arrange
            object obj = 123;
            Type type = typeof(string);

            // Act
            bool result = obj.IsTypeOf(type);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsTypeOf_ThrowsArgumentNullException_WhenObjectIsNull()
        {
            // Arrange
            object obj = null;
            Type type = typeof(string);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => obj.IsTypeOf(type));
        }

        [Fact]
        public void IsTypeOf_ReturnsFalse_WhenTypeIsNull()
        {
            // Arrange
            object obj = 123;

            // Act
            bool result = obj.IsTypeOf(null);

            // Assert
            Assert.False(result);
        }
    }
}
