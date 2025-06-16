namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public class NullableDateTimeOffset_GetNextMonthFirstDayTests
    {
        [Fact]
        public void GetNextMonthFirstDay_NullInput_ReturnsNull()
        {
            DateTimeOffset? input = null;
            var result = input.GetNextMonthFirstDay();
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2024, 1, 15, 2024, 2, 1)]
        [InlineData(2024, 12, 31, 2025, 1, 1)]
        [InlineData(2020, 2, 29, 2020, 3, 1)]
        [InlineData(2023, 11, 1, 2023, 12, 1)]
        public void GetNextMonthFirstDay_ValidInput_ReturnsFirstDayOfNextMonth(
            int year, int month, int day, int expectedYear, int expectedMonth, int expectedDay)
        {
            DateTimeOffset? input = new DateTimeOffset(year, month, day, 10, 20, 30, TimeSpan.Zero);
            var expected = new DateTimeOffset(expectedYear, expectedMonth, expectedDay, 10, 20, 30, TimeSpan.Zero);
            var result = input.GetNextMonthFirstDay();
            Assert.NotNull(result);
            Assert.Equal(expected, result.Value);
        }
    }
}
