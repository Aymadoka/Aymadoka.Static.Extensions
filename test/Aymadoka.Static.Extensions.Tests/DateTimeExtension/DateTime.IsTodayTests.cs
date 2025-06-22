namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_IsTodayTests
    {
        [Fact]
        public void IsToday_ReturnsTrue_WhenDateIsToday()
        {
            // Arrange
            var today = DateTime.Today;

            // Act
            var result = today.IsToday();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsToday_ReturnsFalse_WhenDateIsNotToday()
        {
            // Arrange
            var yesterday = DateTime.Today.AddDays(-1);
            var tomorrow = DateTime.Today.AddDays(1);

            // Act & Assert
            Assert.False(yesterday.IsToday());
            Assert.False(tomorrow.IsToday());
        }

        [Fact]
        public void IsToday_ReturnsTrue_WhenDateTimeHasTimeComponentButIsToday()
        {
            // Arrange
            var now = DateTime.Now;

            // Act
            var result = now.IsToday();

            // Assert
            Assert.True(result);
        }
    }
}
