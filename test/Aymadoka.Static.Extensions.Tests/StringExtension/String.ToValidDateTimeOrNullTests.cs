namespace Aymadoka.Static.StringExtension
{
    public class String_ToValidDateTimeOrNullTests
    {
        [Theory]
        [InlineData("2024-06-01", 2024, 6, 1)]
        [InlineData("1999/12/31", 1999, 12, 31)]
        [InlineData("2020-02-29", 2020, 2, 29)]
        [InlineData("2024-06-01T15:30:00", 2024, 6, 1)]
        public void ToValidDateTimeOrNull_ValidDateStrings_ReturnsDateTime(string input, int year, int month, int day)
        {
            var result = input.ToValidDateTimeOrNull();
            Assert.NotNull(result);
            Assert.Equal(year, result.Value.Year);
            Assert.Equal(month, result.Value.Month);
            Assert.Equal(day, result.Value.Day);
        }

        [Theory]
        [InlineData("not a date")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("2024-13-01")]
        [InlineData("2024-02-30")]
        public void ToValidDateTimeOrNull_InvalidOrNullStrings_ReturnsNull(string input)
        {
            var result = input.ToValidDateTimeOrNull();
            Assert.Null(result);
        }
    }
}
