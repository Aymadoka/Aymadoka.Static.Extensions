namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public class NullableDateTimeOffset_IsWeekendTests
    {
        [Theory]
        [InlineData(2024, 6, 8, true)]  // Saturday
        [InlineData(2024, 6, 9, true)]  // Sunday
        [InlineData(2024, 6, 10, false)] // Monday
        [InlineData(2024, 6, 11, false)] // Tuesday
        [InlineData(2024, 6, 12, false)] // Wednesday
        [InlineData(2024, 6, 13, false)] // Thursday
        [InlineData(2024, 6, 14, false)] // Friday
        public void IsWeekend_ReturnsExpectedResult(int year, int month, int day, bool expected)
        {
            DateTimeOffset? date = new DateTimeOffset(year, month, day, 0, 0, 0, TimeSpan.Zero);
            var result = date.IsWeekend();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsWeekend_Null_ReturnsFalse()
        {
            DateTimeOffset? date = null;
            var result = date.IsWeekend();
            Assert.False(result);
        }
    }
}
