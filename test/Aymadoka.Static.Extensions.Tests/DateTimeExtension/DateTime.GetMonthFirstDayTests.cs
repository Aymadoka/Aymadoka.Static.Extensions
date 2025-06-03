namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_GetMonthFirstDayTests
    {
        [Theory]
        [InlineData(2024, 6, 15, 2024, 6, 1)]
        [InlineData(2020, 2, 29, 2020, 2, 1)]
        [InlineData(2023, 1, 1, 2023, 1, 1)]
        [InlineData(2023, 12, 31, 2023, 12, 1)]
        public void GetMonthFirstDay_ReturnsFirstDayOfMonth(
            int year, int month, int day,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var date = new DateTime(year, month, day);
            var expected = new DateTime(expectedYear, expectedMonth, expectedDay);

            // Act
            var result = date.GetMonthFirstDay();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
