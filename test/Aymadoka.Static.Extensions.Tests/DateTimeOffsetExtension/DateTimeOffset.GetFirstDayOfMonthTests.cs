namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_GetFirstDayOfMonthTests
    {
        [Theory]
        [InlineData(2024, 6, 15, 0, 0, 0, 0, "2024-06-01T00:00:00+00:00")]
        [InlineData(2020, 2, 29, 12, 30, 0, 0, "2020-02-01T12:30:00+00:00")]
        [InlineData(2023, 1, 1, 23, 59, 59, 0, "2023-01-01T23:59:59+00:00")]
        [InlineData(2022, 12, 31, 8, 0, 0, 0, "2022-12-01T08:00:00+00:00")]
        [InlineData(2024, 6, 1, 0, 0, 0, 0, "2024-06-01T00:00:00+00:00")]
        public void GetFirstDayOfMonth_ReturnsFirstDayOfMonth(
    int year, int month, int day, int hour, int minute, int second, int offsetMinutes, string expectedIso)
        {
            var offset = TimeSpan.FromMinutes(offsetMinutes);
            var input = new DateTimeOffset(year, month, day, hour, minute, second, offset);
            var expected = DateTimeOffset.Parse(expectedIso);

            var result = input.GetMonthFirstDay();

            Assert.Equal(expected.Year, result.Year);
            Assert.Equal(expected.Month, result.Month);
            Assert.Equal(1, result.Day);
            Assert.Equal(input.Hour, result.Hour);
            Assert.Equal(input.Minute, result.Minute);
            Assert.Equal(input.Second, result.Second);
            Assert.Equal(input.Offset, result.Offset);
        }
    }
}
