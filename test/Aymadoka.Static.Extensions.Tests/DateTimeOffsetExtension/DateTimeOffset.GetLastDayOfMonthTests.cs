namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_GetLastDayOfMonthTests
    {
        [Theory]
        [InlineData(2024, 1, 15, 31)]
        [InlineData(2024, 2, 10, 29)] // 闰年
        [InlineData(2023, 2, 10, 28)] // 平年
        [InlineData(2023, 4, 1, 30)]
        [InlineData(2023, 12, 31, 31)]
        public void GetLastDayOfMonth_ReturnsCorrectLastDay(int year, int month, int day, int expectedLastDay)
        {
            var date = new DateTimeOffset(year, month, day, 12, 34, 56, TimeSpan.Zero);
            var lastDay = date.GetMonthLastDay();

            Assert.Equal(year, lastDay.Year);
            Assert.Equal(month, lastDay.Month);
            Assert.Equal(expectedLastDay, lastDay.Day);
            Assert.Equal(date.Hour, lastDay.Hour);
            Assert.Equal(date.Minute, lastDay.Minute);
            Assert.Equal(date.Second, lastDay.Second);
            Assert.Equal(date.Offset, lastDay.Offset);
        }
    }
}
