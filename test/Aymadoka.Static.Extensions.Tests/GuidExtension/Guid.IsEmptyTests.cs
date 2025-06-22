namespace Aymadoka.Static.GuidExtension
{
    public class Guid_IsEmptyTests
    {
        public class GuidExtensionsTests
        {
            [Fact]
            public void IsEmpty_ReturnsTrue_WhenGuidIsEmpty()
            {
                // Arrange
                var guid = Guid.Empty;

                // Act
                var result = guid.IsEmpty();

                // Assert
                Assert.True(result);
            }

            [Fact]
            public void IsEmpty_ReturnsFalse_WhenGuidIsNotEmpty()
            {
                // Arrange
                var guid = Guid.NewGuid();

                // Act
                var result = guid.IsEmpty();

                // Assert
                Assert.False(result);
            }
        }
    }
}
