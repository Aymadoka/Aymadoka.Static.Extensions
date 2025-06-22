namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_GetWeekFirstDayTests
    {
        [Theory]
        [InlineData("2024-06-12", DayOfWeek.Monday, "2024-06-10")]
        [InlineData("2024-06-16", DayOfWeek.Monday, "2024-06-10")]
        [InlineData("2024-06-16", DayOfWeek.Sunday, "2024-06-16")]
        [InlineData("2024-06-10", DayOfWeek.Monday, "2024-06-10")]
        [InlineData("2024-06-09", DayOfWeek.Sunday, "2024-06-09")]
        [InlineData("2024-06-09", DayOfWeek.Monday, "2024-06-03")]
        public void GetWeekFirstDay_WithCustomStartDay_ReturnsCorrectDate(string date, DayOfWeek weekStartsOn, string expected)
        {
            var dt = DateTime.Parse(date);
            var expectedDt = DateTime.Parse(expected);
            var result = dt.GetWeekFirstDay(weekStartsOn);
            Assert.Equal(expectedDt, result);
            Assert.Equal(0, result.Hour);
            Assert.Equal(0, result.Minute);
            Assert.Equal(0, result.Second);
        }

        [Theory]
        [InlineData("2024-06-12", "2024-06-10")]
        [InlineData("2024-06-10", "2024-06-10")]
        [InlineData("2024-06-09", "2024-06-03")]
        public void GetWeekFirstDay_DefaultMondayStart_ReturnsCorrectDate(string date, string expected)
        {
            var dt = DateTime.Parse(date);
            var expectedDt = DateTime.Parse(expected);
            var result = dt.GetWeekFirstDay();
            Assert.Equal(expectedDt, result);
            Assert.Equal(0, result.Hour);
            Assert.Equal(0, result.Minute);
            Assert.Equal(0, result.Second);
        }

        [Fact]
        public void GetWeekFirstDay_PreservesKind()
        {
            var local = new DateTime(2024, 6, 12, 15, 30, 0, DateTimeKind.Local);
            var utc = new DateTime(2024, 6, 12, 15, 30, 0, DateTimeKind.Utc);
            var unspecified = new DateTime(2024, 6, 12, 15, 30, 0, DateTimeKind.Unspecified);

            Assert.Equal(DateTimeKind.Local, local.GetWeekFirstDay().Kind);
            Assert.Equal(DateTimeKind.Utc, utc.GetWeekFirstDay().Kind);
            Assert.Equal(DateTimeKind.Unspecified, unspecified.GetWeekFirstDay().Kind);
        }
    }
}
