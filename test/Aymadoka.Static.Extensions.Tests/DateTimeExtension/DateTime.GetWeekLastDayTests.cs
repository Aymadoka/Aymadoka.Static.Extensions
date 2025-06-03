namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_GetWeekLastDayTests
    {
        [Theory]
        [InlineData(2024, 6, 9, DayOfWeek.Sunday, "2024-06-09")] // 周日
        [InlineData(2024, 6, 10, DayOfWeek.Monday, "2024-06-16")] // 周一
        [InlineData(2024, 6, 11, DayOfWeek.Tuesday, "2024-06-16")] // 周二
        [InlineData(2024, 6, 12, DayOfWeek.Wednesday, "2024-06-16")] // 周三
        [InlineData(2024, 6, 13, DayOfWeek.Thursday, "2024-06-16")] // 周四
        [InlineData(2024, 6, 14, DayOfWeek.Friday, "2024-06-16")] // 周五
        [InlineData(2024, 6, 15, DayOfWeek.Saturday, "2024-06-16")] // 周六
        public void GetWeekLastDay_ReturnsSunday(int year, int month, int day, DayOfWeek expectedDayOfWeek, string expectedDate)
        {
            var input = new DateTime(year, month, day, 15, 30, 45, DateTimeKind.Local);
            var result = input.GetWeekLastDay();
            Assert.Equal(DateTime.Parse(expectedDate), result.Date);
            Assert.Equal(0, result.Hour);
            Assert.Equal(0, result.Minute);
            Assert.Equal(0, result.Second);
            Assert.Equal(expectedDayOfWeek == DayOfWeek.Sunday ? input.DayOfWeek : DayOfWeek.Sunday, result.DayOfWeek);
            Assert.Equal(input.Kind, result.Kind);
        }

        [Fact]
        public void GetWeekLastDay_PreservesDateTimeKind()
        {
            var local = new DateTime(2024, 6, 10, 12, 0, 0, DateTimeKind.Local);
            var utc = new DateTime(2024, 6, 10, 12, 0, 0, DateTimeKind.Utc);
            var unspecified = new DateTime(2024, 6, 10, 12, 0, 0, DateTimeKind.Unspecified);

            Assert.Equal(DateTimeKind.Local, local.GetWeekLastDay().Kind);
            Assert.Equal(DateTimeKind.Utc, utc.GetWeekLastDay().Kind);
            Assert.Equal(DateTimeKind.Unspecified, unspecified.GetWeekLastDay().Kind);
        }
    }
}
