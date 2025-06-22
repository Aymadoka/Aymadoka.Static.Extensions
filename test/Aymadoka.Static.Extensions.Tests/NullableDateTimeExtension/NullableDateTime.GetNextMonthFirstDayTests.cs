namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_GetNextMonthFirstDayTests
    {
        [Fact]
        public void GetNextMonthFirstDay_NullInput_ReturnsNull()
        {
            DateTime? input = null;
            var result = input.GetNextMonthFirstDay();
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2024, 1, 15, 2024, 2, 1)]
        [InlineData(2024, 12, 31, 2025, 1, 1)]
        [InlineData(2023, 2, 28, 2023, 3, 1)]
        [InlineData(2020, 2, 29, 2020, 3, 1)] // 闰年
        public void GetNextMonthFirstDay_ValidDate_ReturnsFirstDayOfNextMonth(
            int year, int month, int day, int expectedYear, int expectedMonth, int expectedDay)
        {
            DateTime? input = new DateTime(year, month, day);
            var result = input.GetNextMonthFirstDay();
            Assert.NotNull(result);
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result.Value);
        }
    }
}
