namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_IsBetweenTests
    {
        [Theory]
        [InlineData("2024-01-01T00:00:00+00:00", "2024-01-01T00:00:00+00:00", "2024-12-31T23:59:59+00:00", true)]
        [InlineData("2024-12-31T23:59:59+00:00", "2024-01-01T00:00:00+00:00", "2024-12-31T23:59:59+00:00", true)]
        [InlineData("2024-06-01T12:00:00+00:00", "2024-01-01T00:00:00+00:00", "2024-12-31T23:59:59+00:00", true)]
        [InlineData("2023-12-31T23:59:59+00:00", "2024-01-01T00:00:00+00:00", "2024-12-31T23:59:59+00:00", false)]
        [InlineData("2025-01-01T00:00:00+00:00", "2024-01-01T00:00:00+00:00", "2024-12-31T23:59:59+00:00", false)]
        public void IsBetween_ReturnsExpectedResult(string value, string start, string end, bool expected)
        {
            var date = DateTimeOffset.Parse(value);
            var startDate = DateTimeOffset.Parse(start);
            var endDate = DateTimeOffset.Parse(end);

            var result = date.IsBetween(startDate, endDate);

            Assert.Equal(expected, result);
        }
    }
}
