namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_IsPastTests
    {
        [Fact]
        public void IsPast_ReturnsTrue_WhenDateTimeIsBeforeNow()
        {
            // Arrange
            var past = DateTime.Now.AddMinutes(-1);

            // Act
            var result = past.IsPast();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPast_ReturnsFalse_WhenDateTimeIsAfterNow()
        {
            // Arrange
            var future = DateTime.Now.AddMinutes(1);

            // Act
            var result = future.IsPast();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPast_ReturnsFalse_WhenDateTimeIsNow()
        {
            // Arrange
            var now = DateTime.Now;

            // Act
            var result = now.IsPast();

            // Assert
            Assert.True(result);
        }
    }
}
