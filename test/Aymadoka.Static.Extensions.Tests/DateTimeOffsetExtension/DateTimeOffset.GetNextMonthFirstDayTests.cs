namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_GetNextMonthFirstDayTests
    {
        [Theory]
        [InlineData(2024, 1, 15, 2024, 2, 1)]
        [InlineData(2024, 12, 31, 2025, 1, 1)]
        [InlineData(2020, 2, 29, 2020, 3, 1)]
        [InlineData(2023, 6, 1, 2023, 7, 1)]
        public void GetNextMonthFirstDay_ReturnsCorrectDate(
            int year, int month, int day,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var input = new DateTimeOffset(year, month, day, 0, 0, 0, TimeSpan.Zero);
            var expected = new DateTimeOffset(expectedYear, expectedMonth, expectedDay, 0, 0, 0, TimeSpan.Zero);

            // Act
            var result = input.GetNextMonthFirstDay();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
