namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_TomorrowTests
    {
        [Fact]
        public void Tomorrow_ShouldReturnNextDay()
        {
            // Arrange
            var date = new DateTime(2024, 6, 1);

            // Act
            var tomorrow = date.Tomorrow();

            // Assert
            Assert.Equal(new DateTime(2024, 6, 2), tomorrow);
        }

        [Fact]
        public void Tomorrow_OnEndOfMonth_ShouldReturnFirstOfNextMonth()
        {
            // Arrange
            var date = new DateTime(2024, 1, 31);

            // Act
            var tomorrow = date.Tomorrow();

            // Assert
            Assert.Equal(new DateTime(2024, 2, 1), tomorrow);
        }

        [Fact]
        public void Tomorrow_OnEndOfYear_ShouldReturnFirstOfNextYear()
        {
            // Arrange
            var date = new DateTime(2023, 12, 31);

            // Act
            var tomorrow = date.Tomorrow();

            // Assert
            Assert.Equal(new DateTime(2024, 1, 1), tomorrow);
        }
    }
}
