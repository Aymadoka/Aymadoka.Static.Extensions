namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_YesterdayTests
    {
        [Fact]
        public void Yesterday_ReturnsPreviousDay()
        {
            // Arrange
            var date = new DateTime(2024, 6, 10);

            // Act
            var result = date.Yesterday();

            // Assert
            Assert.Equal(new DateTime(2024, 6, 9), result);
        }

        [Fact]
        public void Yesterday_OnFirstDayOfMonth_ReturnsLastDayOfPreviousMonth()
        {
            // Arrange
            var date = new DateTime(2024, 7, 1);

            // Act
            var result = date.Yesterday();

            // Assert
            Assert.Equal(new DateTime(2024, 6, 30), result);
        }

        [Fact]
        public void Yesterday_OnLeapYear_ReturnsFeb28Or29()
        {
            // Arrange
            var date = new DateTime(2020, 3, 1);

            // Act
            var result = date.Yesterday();

            // Assert
            Assert.Equal(new DateTime(2020, 2, 29), result);
        }
    }
}
