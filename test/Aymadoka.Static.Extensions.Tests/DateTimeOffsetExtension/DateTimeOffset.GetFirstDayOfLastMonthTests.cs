namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_GetFirstDayOfLastMonthTests
    {
        [Theory]
        [InlineData(2024, 6, 15, 8, 30, 0, 2024, 5, 1, 8, 30, 0)]
        [InlineData(2024, 1, 10, 0, 0, 0, 2023, 12, 1, 0, 0, 0)]
        [InlineData(2020, 3, 31, 23, 59, 59, 2020, 2, 1, 23, 59, 59)]
        [InlineData(2020, 2, 29, 12, 0, 0, 2020, 1, 1, 12, 0, 0)]
        public void GetFirstDayOfLastMonth_ReturnsCorrectResult(
            int year, int month, int day, int hour, int minute, int second,
            int expectedYear, int expectedMonth, int expectedDay, int expectedHour, int expectedMinute, int expectedSecond)
        {
            var input = new DateTimeOffset(year, month, day, hour, minute, second, TimeSpan.Zero);
            var expected = new DateTimeOffset(expectedYear, expectedMonth, expectedDay, expectedHour, expectedMinute, expectedSecond, TimeSpan.Zero);

            var result = input.GetLastMonthFirstDay();

            Assert.Equal(expected, result);
        }
    }
}
