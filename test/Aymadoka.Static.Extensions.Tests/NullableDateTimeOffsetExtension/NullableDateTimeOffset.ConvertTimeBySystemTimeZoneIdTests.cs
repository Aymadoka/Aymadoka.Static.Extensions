namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public class NullableDateTimeOffset_ConvertTimeBySystemTimeZoneIdTests
    {
        [Fact]
        public void ConvertTimeBySystemTimeZoneId_NullInput_ReturnsNull()
        {
            DateTimeOffset? input = null;
            var result = input.ConvertTimeBySystemTimeZoneId("China Standard Time");
            Assert.Null(result);
        }

        [Fact]
        public void ConvertTimeBySystemTimeZoneId_ValidInput_ConvertsCorrectly()
        {
            // Arrange
            var utcTime = new DateTimeOffset(2024, 6, 1, 12, 0, 0, TimeSpan.Zero);
            DateTimeOffset? input = utcTime;
            string timeZoneId = "China Standard Time";

            // Act
            var result = input.ConvertTimeBySystemTimeZoneId(timeZoneId);

            // Assert
            var expected = TimeZoneInfo.ConvertTime(utcTime, TimeZoneInfo.FindSystemTimeZoneById(timeZoneId));
            Assert.NotNull(result);
            Assert.Equal(expected, result.Value);
        }

        [Fact]
        public void ConvertTimeBySystemTimeZoneId_InvalidTimeZone_ThrowsException()
        {
            var utcTime = new DateTimeOffset(2024, 6, 1, 12, 0, 0, TimeSpan.Zero);
            DateTimeOffset? input = utcTime;
            string invalidTimeZoneId = "Invalid/TimeZone";

            Assert.Throws<TimeZoneNotFoundException>(() =>
            {
                input.ConvertTimeBySystemTimeZoneId(invalidTimeZoneId);
            });
        }
    }
}
