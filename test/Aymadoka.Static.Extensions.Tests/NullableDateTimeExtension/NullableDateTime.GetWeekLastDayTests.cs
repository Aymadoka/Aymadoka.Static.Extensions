namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_GetWeekLastDayTests
    {
        [Theory]
        [InlineData("2024-06-12", DayOfWeek.Monday, "2024-06-16")] // 周三，周一为起始，周日为最后
        [InlineData("2024-06-10", DayOfWeek.Monday, "2024-06-16")] // 周一，周一为起始
        [InlineData("2024-06-16", DayOfWeek.Monday, "2024-06-16")] // 周日，周一为起始
        [InlineData("2024-06-12", DayOfWeek.Sunday, "2024-06-15")] // 周三，周日为起始，周六为最后
        [InlineData("2024-06-16", DayOfWeek.Sunday, "2024-06-22")] // 周日，周日为起始
        public void GetWeekLastDay_WithWeekStartsOn_ReturnsExpected(string dateStr, DayOfWeek weekStartsOn, string expectedStr)
        {
            DateTime? date = DateTime.Parse(dateStr);
            DateTime? expected = DateTime.Parse(expectedStr);

            // 由于原实现依赖于 DateTime.GetWeekLastDay，需模拟此扩展方法
            DateTime? actual = date.GetWeekLastDay(weekStartsOn);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetWeekLastDay_NullInput_ReturnsNull()
        {
            DateTime? date = null;
            var result = date.GetWeekLastDay(DayOfWeek.Monday);
            Assert.Null(result);
        }

        [Theory]
        [InlineData("2024-06-12", "2024-06-16")] // 默认周一为起始
        [InlineData("2024-06-10", "2024-06-16")]
        [InlineData("2024-06-16", "2024-06-16")]
        public void GetWeekLastDay_DefaultWeekStartsOnMonday_ReturnsExpected(string dateStr, string expectedStr)
        {
            DateTime? date = DateTime.Parse(dateStr);
            DateTime? expected = DateTime.Parse(expectedStr);

            DateTime? actual = date.GetWeekLastDay();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetWeekLastDay_Default_NullInput_ReturnsNull()
        {
            DateTime? date = null;
            var result = date.GetWeekLastDay();
            Assert.Null(result);
        }
    }
}
