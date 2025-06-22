namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_TomorrowTests
    {
        [Fact]
        public void Tomorrow_ShouldReturnNextDay()
        {
            // Arrange
            var today = new DateTimeOffset(2024, 6, 1, 10, 0, 0, TimeSpan.Zero);

            // Act
            var tomorrow = today.Tomorrow();

            // Assert
            Assert.Equal(new DateTimeOffset(2024, 6, 2, 10, 0, 0, TimeSpan.Zero), tomorrow);
        }

        [Fact]
        public void Tomorrow_ShouldPreserveOffset()
        {
            // Arrange
            var today = new DateTimeOffset(2024, 6, 1, 23, 59, 59, TimeSpan.FromHours(8));

            // Act
            var tomorrow = today.Tomorrow();

            // Assert
            Assert.Equal(new DateTimeOffset(2024, 6, 2, 23, 59, 59, TimeSpan.FromHours(8)), tomorrow);
        }
    }
}
