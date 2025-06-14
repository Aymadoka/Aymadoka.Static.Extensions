namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_GetMonthLastDayTests
    {
        [Fact]
        public void GetMonthLastDay_NullInput_ReturnsNull()
        {
            DateTime? input = null;
            var result = input.GetMonthLastDay();
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2024, 6, 1, 2024, 6, 30)]
        [InlineData(2024, 2, 15, 2024, 2, 29)] // 闰年
        [InlineData(2023, 2, 10, 2023, 2, 28)] // 平年
        [InlineData(2024, 12, 31, 2024, 12, 31)]
        public void GetMonthLastDay_ValidDate_ReturnsLastDayOfMonth(int year, int month, int day, int expectedYear, int expectedMonth, int expectedDay)
        {
            DateTime? input = new DateTime(year, month, day);
            var result = input.GetMonthLastDay();
            Assert.NotNull(result);
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result.Value);
        }
    }
}
