namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_IsFutureTests
    {
        [Fact]
        public void IsFuture_ReturnsTrue_WhenDateTimeIsInFuture()
        {
            // Arrange
            var future = DateTime.Now.AddMinutes(10);

            // Act
            var result = future.IsFuture();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsFuture_ReturnsFalse_WhenDateTimeIsInPast()
        {
            // Arrange
            var past = DateTime.Now.AddMinutes(-10);

            // Act
            var result = past.IsFuture();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsFuture_ReturnsFalse_WhenDateTimeIsNow()
        {
            // Arrange
            var now = DateTime.Now;

            // Act
            var result = now.IsFuture();

            // Assert
            Assert.False(result);
        }
    }
}
