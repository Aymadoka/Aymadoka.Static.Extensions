namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_GetCurrentMonthLastDayTests
    {
        [Theory]
        [InlineData(2024, 1, 15, 2024, 1, 31)]
        [InlineData(2024, 2, 1, 2024, 2, 29)] // 闰年2月
        [InlineData(2023, 2, 10, 2023, 2, 28)] // 平年2月
        [InlineData(2024, 4, 30, 2024, 4, 30)]
        [InlineData(2024, 12, 1, 2024, 12, 31)]
        public void GetCurrentMonthLastDay_ReturnsCorrectLastDay(
            int year, int month, int day,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            var date = new DateTime(year, month, day);
            var expected = new DateTime(expectedYear, expectedMonth, expectedDay);
            var actual = date.GetMonthLastDay();
            Assert.Equal(expected, actual);
        }
    }
}
