namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_ConvertTimeBySystemTimeZoneIdTests
    {
        [Theory]
        [InlineData("2024-06-01T12:00:00+00:00", "China Standard Time", 8)]
        [InlineData("2024-06-01T12:00:00+00:00", "Pacific Standard Time", -7)]
        [InlineData("2024-06-01T12:00:00+00:00", "UTC", 0)]
        public void ConvertTimeBySystemTimeZoneId_ShouldConvertToExpectedOffset(string input, string timeZoneId, int expectedOffsetHours)
        {
            // Arrange
            var dateTimeOffset = DateTimeOffset.Parse(input);

            // Act
            var result = dateTimeOffset.ConvertTimeBySystemTimeZoneId(timeZoneId);

            // Assert
            Assert.Equal(expectedOffsetHours, result.Offset.Hours);
        }

        [Fact]
        public void ConvertTimeBySystemTimeZoneId_InvalidTimeZone_ThrowsException()
        {
            // Arrange
            var dateTimeOffset = DateTimeOffset.UtcNow;
            var invalidTimeZoneId = "Invalid/TimeZone";

            // Act & Assert
            Assert.Throws<TimeZoneNotFoundException>(() =>
                dateTimeOffset.ConvertTimeBySystemTimeZoneId(invalidTimeZoneId));
        }
    }
}
