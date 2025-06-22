namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_ConvertTimeTests
    {
        [Fact]
        public void ConvertTime_ShouldConvertToDestinationTimeZone()
        {
            // Arrange
            var utcTime = new DateTimeOffset(2024, 6, 1, 12, 0, 0, TimeSpan.Zero);
            var chinaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");

            // Act
            var result = utcTime.ConvertTime(chinaTimeZone);

            // Assert
            Assert.Equal(utcTime.UtcDateTime + chinaTimeZone.BaseUtcOffset, result.DateTime);
            Assert.Equal(chinaTimeZone.BaseUtcOffset, result.Offset);
        }

        [Fact]
        public void ConvertTime_ShouldReturnSameTime_WhenTimeZoneIsUtc()
        {
            // Arrange
            var utcTime = new DateTimeOffset(2024, 6, 1, 12, 0, 0, TimeSpan.Zero);
            var utcZone = TimeZoneInfo.Utc;

            // Act
            var result = utcTime.ConvertTime(utcZone);

            // Assert
            Assert.Equal(utcTime, result);
        }

        [Fact]
        public void ConvertTime_ShouldThrow_WhenTimeZoneIsNull()
        {
            // Arrange
            var utcTime = new DateTimeOffset(2024, 6, 1, 12, 0, 0, TimeSpan.Zero);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => utcTime.ConvertTime(null));
        }
    }
}
