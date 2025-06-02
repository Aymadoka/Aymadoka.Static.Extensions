namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_IsWeekendDayTests
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
            var date = new DateTime(year, month, day);
            var result = date.IsWeekendDay();
            Assert.Equal(expected, result);
        }
    }
}
