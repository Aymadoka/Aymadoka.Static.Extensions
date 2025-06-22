namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_ToEpochTimeSpanTests
    {
        [Fact]
        public void ToEpochTimeSpan_ShouldReturnZero_ForUnixEpoch()
        {
            // Arrange
            var dateTime = DateTimeOffset.UnixEpoch;

            // Act
            var result = dateTime.ToEpochTimeSpan();

            // Assert
            Assert.Equal(TimeSpan.Zero, result);
        }

        [Fact]
        public void ToEpochTimeSpan_ShouldReturnPositiveTimeSpan_ForAfterUnixEpoch()
        {
            // Arrange
            var dateTime = DateTimeOffset.UnixEpoch.AddSeconds(12345);

            // Act
            var result = dateTime.ToEpochTimeSpan();

            // Assert
            Assert.Equal(TimeSpan.FromSeconds(12345), result);
        }

        [Fact]
        public void ToEpochTimeSpan_ShouldReturnNegativeTimeSpan_ForBeforeUnixEpoch()
        {
            // Arrange
            var dateTime = DateTimeOffset.UnixEpoch.AddMinutes(-10);

            // Act
            var result = dateTime.ToEpochTimeSpan();

            // Assert
            Assert.Equal(TimeSpan.FromMinutes(-10), result);
        }

        [Fact]
        public void ToEpochTimeSpan_ShouldHandleDifferentOffsets()
        {
            // Arrange
            var dateTime = new DateTimeOffset(1970, 1, 1, 1, 0, 0, TimeSpan.FromHours(1)); // 1970-01-01T00:00:00Z

            // Act
            var result = dateTime.ToEpochTimeSpan();

            // Assert
            Assert.Equal(TimeSpan.Zero, result);
        }
    }
}
