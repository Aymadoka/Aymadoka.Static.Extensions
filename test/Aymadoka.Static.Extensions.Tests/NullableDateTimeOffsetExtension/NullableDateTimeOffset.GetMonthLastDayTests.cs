namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public class NullableDateTimeOffset_GetMonthLastDayTests
    {
        [Fact]
        public void GetMonthLastDay_NullInput_ReturnsNull()
        {
            DateTimeOffset? input = null;
            var result = input.GetMonthLastDay();
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2024, 2, 1, 2024, 2, 29)] // 闰年2月
        [InlineData(2023, 2, 15, 2023, 2, 28)] // 平年2月
        [InlineData(2023, 1, 10, 2023, 1, 31)]
        [InlineData(2023, 4, 5, 2023, 4, 30)]
        [InlineData(2023, 12, 25, 2023, 12, 31)]
        public void GetMonthLastDay_ValidInput_ReturnsLastDay(
            int year, int month, int day,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            DateTimeOffset? input = new DateTimeOffset(year, month, day, 0, 0, 0, TimeSpan.Zero);
            var expected = new DateTimeOffset(expectedYear, expectedMonth, expectedDay, 0, 0, 0, TimeSpan.Zero);
            var result = input.GetMonthLastDay();
            Assert.Equal(expected, result);
        }
    }
}
