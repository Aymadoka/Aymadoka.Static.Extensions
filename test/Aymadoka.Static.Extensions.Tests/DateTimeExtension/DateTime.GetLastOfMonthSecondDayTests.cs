namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_GetLastOfMonthSecondDayTests
    {
        [Theory]
        [InlineData(2024, 6, 1, 2024, 6, 29)] // 6月有30天
        [InlineData(2024, 2, 10, 2024, 2, 28)] // 闰年2月有29天
        [InlineData(2023, 2, 15, 2023, 2, 27)] // 平年2月有28天
        [InlineData(2024, 12, 31, 2024, 12, 30)] // 12月有31天
        [InlineData(2024, 4, 5, 2024, 4, 29)] // 4月有30天
        public void GetLastOfMonthSecondDay_ReturnsExpectedDate(
            int year, int month, int day,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var date = new DateTime(year, month, day);
            var expected = new DateTime(expectedYear, expectedMonth, expectedDay);

            // Act
            var result = date.GetMonthSecondDay();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
