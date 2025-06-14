namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_IsWeekDayTests
    {
        [Theory]
        [InlineData(2024, 6, 10, true)] // 周一
        [InlineData(2024, 6, 11, true)] // 周二
        [InlineData(2024, 6, 12, true)] // 周三
        [InlineData(2024, 6, 13, true)] // 周四
        [InlineData(2024, 6, 14, true)] // 周五
        [InlineData(2024, 6, 15, false)] // 周六
        [InlineData(2024, 6, 16, false)] // 周日
        public void IsWeekDay_ReturnsExpectedResult(int year, int month, int day, bool expected)
        {
            DateTime? date = new DateTime(year, month, day);
            Assert.Equal(expected, date.IsWeekDay());
        }

        [Fact]
        public void IsWeekDay_NullDate_ReturnsFalse()
        {
            DateTime? date = null;
            Assert.False(date.IsWeekDay());
        }
    }
}
