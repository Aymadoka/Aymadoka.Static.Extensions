namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_GetSecondLevelTimeStampTests
    {
        [Fact]
        public void GetSecondLevelTimeStamp_ReturnsCorrectUnixTimeSeconds()
        {
            // Arrange
            var dateTime = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);

            // Act
            var timestamp = dateTime.GetSecondLevelTimeStamp();

            // Assert
            Assert.Equal(0, timestamp);
        }

        [Fact]
        public void GetSecondLevelTimeStamp_WithSpecificDate_ReturnsExpectedValue()
        {
            // Arrange
            var dateTime = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
            var expected = dateTime.ToUnixTimeSeconds();

            // Act
            var timestamp = dateTime.GetSecondLevelTimeStamp();

            // Assert
            Assert.Equal(expected, timestamp);
        }

        [Fact]
        public void GetSecondLevelTimeStamp_WithLocalTimeZone_ReturnsUtcBasedTimestamp()
        {
            // Arrange
            var localDateTime = new DateTimeOffset(2024, 6, 1, 12, 0, 0, TimeSpan.FromHours(8));
            var expected = localDateTime.ToUnixTimeSeconds();

            // Act
            var timestamp = localDateTime.GetSecondLevelTimeStamp();

            // Assert
            Assert.Equal(expected, timestamp);
        }
    }
}
