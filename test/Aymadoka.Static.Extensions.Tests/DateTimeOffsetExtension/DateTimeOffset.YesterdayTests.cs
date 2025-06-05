namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_YesterdayTests
    {
        [Fact]
        public void Yesterday_ShouldReturnPreviousDay()
        {
            // Arrange
            var now = new DateTimeOffset(2024, 6, 10, 12, 0, 0, TimeSpan.Zero);
            var expected = new DateTimeOffset(2024, 6, 9, 12, 0, 0, TimeSpan.Zero);

            // Act
            var result = now.Yesterday();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Yesterday_ShouldHandleMonthBoundary()
        {
            // Arrange
            var now = new DateTimeOffset(2024, 3, 1, 0, 0, 0, TimeSpan.Zero);
            var expected = new DateTimeOffset(2024, 2, 29, 0, 0, 0, TimeSpan.Zero); // 2024 is a leap year

            // Act
            var result = now.Yesterday();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Yesterday_ShouldPreserveOffset()
        {
            // Arrange
            var now = new DateTimeOffset(2024, 6, 10, 8, 0, 0, TimeSpan.FromHours(8));
            var expected = new DateTimeOffset(2024, 6, 9, 8, 0, 0, TimeSpan.FromHours(8));

            // Act
            var result = now.Yesterday();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
