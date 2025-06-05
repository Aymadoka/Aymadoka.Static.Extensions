namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_GetSecondDayToLastOfMonthTests
    {
        [Theory]
        [InlineData(2024, 6, 15, 2024, 6, 29)] // 6月有30天，倒数第二天是29
        [InlineData(2024, 2, 10, 2024, 2, 27)] // 闰年2月有29天，倒数第二天是27
        [InlineData(2023, 2, 1, 2023, 2, 26)]  // 平年2月有28天，倒数第二天是26
        [InlineData(2024, 1, 31, 2024, 1, 30)] // 1月有31天，倒数第二天是30
        [InlineData(2024, 4, 1, 2024, 4, 29)]  // 4月有30天，倒数第二天是29
        public void GetSecondDayToLastOfMonth_ReturnsExpectedDate(
            int year, int month, int day,
            int expectedYear, int expectedMonth, int expectedDay)
        {
            // Arrange
            var input = new DateTimeOffset(year, month, day, 0, 0, 0, TimeSpan.Zero);
            var expected = new DateTimeOffset(expectedYear, expectedMonth, expectedDay, 0, 0, 0, TimeSpan.Zero);

            // Act
            var result = input.GetSecondDayToLastOfMonth();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
