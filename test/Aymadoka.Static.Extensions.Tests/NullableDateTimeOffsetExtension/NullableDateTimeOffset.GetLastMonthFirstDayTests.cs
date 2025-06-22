namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public class NullableDateTimeOffset_GetLastMonthFirstDayTests
    {
        [Fact]
        public void GetLastMonthFirstDay_NullInput_ReturnsNull()
        {
            DateTimeOffset? input = null;
            var result = input.GetLastMonthFirstDay();
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2024, 6, 15, 2024, 5, 1)]
        [InlineData(2024, 1, 10, 2023, 12, 1)]
        [InlineData(2020, 3, 31, 2020, 2, 1)]
        public void GetLastMonthFirstDay_ValidInput_ReturnsFirstDayOfLastMonth(
            int year, int month, int day,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            DateTimeOffset? input = new DateTimeOffset(year, month, day, 0, 0, 0, TimeSpan.Zero);
            var expected = new DateTimeOffset(expectedYear, expectedMonth, expectedDay, 0, 0, 0, TimeSpan.Zero);

            var result = input.GetLastMonthFirstDay();

            Assert.NotNull(result);
            Assert.Equal(expected, result);
        }
    }
}
