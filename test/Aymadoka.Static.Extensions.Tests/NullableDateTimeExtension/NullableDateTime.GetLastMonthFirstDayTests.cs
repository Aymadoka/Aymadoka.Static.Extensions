namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_GetLastMonthFirstDayTests
    {
        [Fact]
        public void GetLastMonthFirstDay_NullInput_ReturnsNull()
        {
            DateTime? input = null;
            var result = input.GetLastMonthFirstDay();
            Assert.Null(result);
        }

        [Theory]
        [InlineData(2024, 6, 15, 2024, 5, 1)]
        [InlineData(2024, 1, 1, 2023, 12, 1)]
        [InlineData(2020, 3, 31, 2020, 2, 1)]
        public void GetLastMonthFirstDay_ValidInput_ReturnsFirstDayOfLastMonth(
            int year, int month, int day, int expectedYear, int expectedMonth, int expectedDay)
        {
            DateTime? input = new DateTime(year, month, day);
            var result = input.GetLastMonthFirstDay();
            Assert.NotNull(result);
            Assert.Equal(new DateTime(expectedYear, expectedMonth, expectedDay), result.Value);
        }
    }
}
