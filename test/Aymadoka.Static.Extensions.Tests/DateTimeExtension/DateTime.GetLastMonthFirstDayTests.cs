namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_GetLastMonthFirstDayTests
    {
        [Theory]
        [InlineData("2024-06-15", "2024-05-01")]
        [InlineData("2024-01-01", "2023-12-01")]
        [InlineData("2020-03-31", "2020-02-01")]
        [InlineData("2020-02-29", "2020-01-01")]
        [InlineData("2023-12-31", "2023-11-01")]
        public void GetLastMonthFirstDay_ReturnsExpectedResult(string input, string expected)
        {
            // Arrange
            var date = DateTime.Parse(input);
            var expectedDate = DateTime.Parse(expected);

            // Act
            var result = date.GetLastMonthFirstDay();

            // Assert
            Assert.Equal(expectedDate, result);
        }
    }
}
