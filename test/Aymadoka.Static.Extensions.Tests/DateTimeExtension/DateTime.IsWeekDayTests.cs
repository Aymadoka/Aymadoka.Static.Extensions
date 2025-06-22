namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_IsWeekDayTests
    {
        [Theory]
        [InlineData(2024, 6, 10, true)] // Monday
        [InlineData(2024, 6, 11, true)] // Tuesday
        [InlineData(2024, 6, 12, true)] // Wednesday
        [InlineData(2024, 6, 13, true)] // Thursday
        [InlineData(2024, 6, 14, true)] // Friday
        [InlineData(2024, 6, 15, false)] // Saturday
        [InlineData(2024, 6, 16, false)] // Sunday
        public void IsWeekDay_ReturnsExpectedResult(int year, int month, int day, bool expected)
        {
            var date = new DateTime(year, month, day);
            var result = date.IsWeekDay();
            Assert.Equal(expected, result);
        }
    }
}
