namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_GetWeekFirstDayTests
    {
        [Theory]
        [InlineData("2024-06-12", DayOfWeek.Monday, "2024-06-10")]
        [InlineData("2024-06-12", DayOfWeek.Sunday, "2024-06-09")]
        [InlineData("2024-06-16", DayOfWeek.Monday, "2024-06-10")]
        [InlineData("2024-06-16", DayOfWeek.Sunday, "2024-06-16")]
        [InlineData("2024-06-10", DayOfWeek.Monday, "2024-06-10")]
        [InlineData("2024-06-09", DayOfWeek.Sunday, "2024-06-09")]
        public void GetWeekFirstDay_WithWeekStartsOn_ReturnsExpected(string dateStr, DayOfWeek weekStartsOn, string expectedStr)
        {
            DateTime? date = DateTime.Parse(dateStr);
            DateTime? expected = DateTime.Parse(expectedStr);

            var result = date.GetWeekFirstDay(weekStartsOn);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetWeekFirstDay_WithNullDate_ReturnsNull()
        {
            DateTime? date = null;
            var result = date.GetWeekFirstDay(DayOfWeek.Monday);
            Assert.Null(result);
        }

        [Theory]
        [InlineData("2024-06-12", "2024-06-10")] // 默认周一
        [InlineData("2024-06-09", "2024-06-03")]
        public void GetWeekFirstDay_DefaultMonday_ReturnsExpected(string dateStr, string expectedStr)
        {
            DateTime? date = DateTime.Parse(dateStr);
            DateTime? expected = DateTime.Parse(expectedStr);

            var result = date.GetWeekFirstDay();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetWeekFirstDay_DefaultMonday_WithNullDate_ReturnsNull()
        {
            DateTime? date = null;
            var result = date.GetWeekFirstDay();
            Assert.Null(result);
        }
    }
}
