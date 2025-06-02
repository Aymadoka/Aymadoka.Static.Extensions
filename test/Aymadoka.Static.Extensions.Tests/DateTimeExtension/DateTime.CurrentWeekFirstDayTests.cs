namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_CurrentWeekFirstDayTests
    {
        [Theory]
        [InlineData(2024, 6, 9, DayOfWeek.Sunday, 2024, 6, 9)]   // 周日
        [InlineData(2024, 6, 10, DayOfWeek.Monday, 2024, 6, 9)]  // 周一
        [InlineData(2024, 6, 11, DayOfWeek.Tuesday, 2024, 6, 9)] // 周二
        [InlineData(2024, 6, 12, DayOfWeek.Wednesday, 2024, 6, 9)] // 周三
        [InlineData(2024, 6, 13, DayOfWeek.Thursday, 2024, 6, 9)] // 周四
        [InlineData(2024, 6, 14, DayOfWeek.Friday, 2024, 6, 9)]  // 周五
        [InlineData(2024, 6, 15, DayOfWeek.Saturday, 2024, 6, 9)] // 周六
        public void CurrentWeekFirstDay_ReturnsSunday(int year, int month, int day, DayOfWeek dayOfWeek, int expectedYear, int expectedMonth, int expectedDay)
        {
            var date = new DateTime(year, month, day, 15, 30, 45, DateTimeKind.Local);
            Assert.Equal(dayOfWeek, date.DayOfWeek);

            var firstDay = date.CurrentWeekFirstDay();

            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay, 0, 0, 0, DateTimeKind.Local), firstDay);
            Assert.Equal(DateTimeKind.Local, firstDay.Kind);
        }

        [Fact]
        public void CurrentWeekFirstDay_PreservesDateTimeKind()
        {
            var utcDate = new DateTime(2024, 6, 12, 10, 0, 0, DateTimeKind.Utc);
            var localDate = new DateTime(2024, 6, 12, 10, 0, 0, DateTimeKind.Local);
            var unspecifiedDate = new DateTime(2024, 6, 12, 10, 0, 0, DateTimeKind.Unspecified);

            Assert.Equal(DateTimeKind.Utc, utcDate.CurrentWeekFirstDay().Kind);
            Assert.Equal(DateTimeKind.Local, localDate.CurrentWeekFirstDay().Kind);
            Assert.Equal(DateTimeKind.Unspecified, unspecifiedDate.CurrentWeekFirstDay().Kind);
        }
    }
}
