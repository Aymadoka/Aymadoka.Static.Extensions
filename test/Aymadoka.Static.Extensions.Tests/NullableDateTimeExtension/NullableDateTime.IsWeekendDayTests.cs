namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_IsWeekendDayTests
    {
        [Theory]
        [InlineData(2024, 6, 8, true)]   // Saturday
        [InlineData(2024, 6, 9, true)]   // Sunday
        [InlineData(2024, 6, 10, false)] // Monday
        [InlineData(2024, 6, 11, false)] // Tuesday
        [InlineData(2024, 6, 12, false)] // Wednesday
        [InlineData(2024, 6, 13, false)] // Thursday
        [InlineData(2024, 6, 14, false)] // Friday
        public void IsWeekendDay_ReturnsExpectedResult(int year, int month, int day, bool expected)
        {
            DateTime? date = new DateTime(year, month, day);
            var result = date.IsWeekendDay();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsWeekendDay_Null_ReturnsFalse()
        {
            DateTime? date = null;
            var result = date.IsWeekendDay();
            Assert.False(result);
        }
    }
}
