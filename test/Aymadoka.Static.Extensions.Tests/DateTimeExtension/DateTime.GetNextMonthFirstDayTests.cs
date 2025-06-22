namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_GetNextMonthFirstDayTests
    {
        [Theory]
        [InlineData(2024, 1, 15, 2024, 2, 1)]
        [InlineData(2024, 12, 31, 2025, 1, 1)]
        [InlineData(2023, 2, 28, 2023, 3, 1)]
        [InlineData(2020, 2, 29, 2020, 3, 1)] // 闰年
        [InlineData(2024, 6, 1, 2024, 7, 1)]
        public void GetNextMonthFirstDay_Returns_CorrectDate(
    int year, int month, int day,
    int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var date = new DateTime(year, month, day);
            var expected = new DateTime(expectedYear, expectedMonth, expectedDay);

            // Act
            var result = date.GetNextMonthFirstDay();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
