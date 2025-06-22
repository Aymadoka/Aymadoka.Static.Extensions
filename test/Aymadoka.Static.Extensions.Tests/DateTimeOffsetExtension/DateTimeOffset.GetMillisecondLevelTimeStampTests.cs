namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_GetMillisecondLevelTimeStampTests
    {
        [Fact]
        public void GetMillisecondLevelTimeStamp_ReturnsCorrectUnixMilliseconds()
        {
            // Arrange
            var dateTime = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);

            // Act
            var timestamp = dateTime.GetMillisecondLevelTimeStamp();

            // Assert
            Assert.Equal(0, timestamp);
        }

        [Fact]
        public void GetMillisecondLevelTimeStamp_WithSpecificDate_ReturnsExpectedValue()
        {
            // Arrange
            var dateTime = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
            var expected = dateTime.ToUnixTimeMilliseconds();

            // Act
            var timestamp = dateTime.GetMillisecondLevelTimeStamp();

            // Assert
            Assert.Equal(expected, timestamp);
        }

        [Fact]
        public void GetMillisecondLevelTimeStamp_WithNonUtcOffset_ReturnsExpectedValue()
        {
            // Arrange
            var dateTime = new DateTimeOffset(2024, 6, 1, 12, 0, 0, TimeSpan.FromHours(8));
            var expected = dateTime.ToUnixTimeMilliseconds();

            // Act
            var timestamp = dateTime.GetMillisecondLevelTimeStamp();

            // Assert
            Assert.Equal(expected, timestamp);
        }
    }
}
