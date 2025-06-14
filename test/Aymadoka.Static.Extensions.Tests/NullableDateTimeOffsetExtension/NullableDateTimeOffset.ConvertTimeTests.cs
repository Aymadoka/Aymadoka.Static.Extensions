namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public class NullableDateTimeOffset_ConvertTimeTests
    {
        [Fact]
        public void ConvertTime_NullInput_ReturnsNull()
        {
            // Arrange
            DateTimeOffset? input = null;
            var timeZone = TimeZoneInfo.Utc;

            // Act
            var result = input.ConvertTime(timeZone);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void ConvertTime_ValidInput_ConvertsToDestinationTimeZone()
        {
            // Arrange
            var sourceTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            var destinationTimeZone = TimeZoneInfo.Utc;
            var localTime = new DateTimeOffset(2024, 6, 1, 12, 0, 0, sourceTimeZone.BaseUtcOffset);
            DateTimeOffset? input = localTime;

            // Act
            var result = input.ConvertTime(destinationTimeZone);

            // Assert
            Assert.NotNull(result);
            var expected = TimeZoneInfo.ConvertTime(localTime, destinationTimeZone);
            Assert.Equal(expected, result.Value);
        }
    }
}
