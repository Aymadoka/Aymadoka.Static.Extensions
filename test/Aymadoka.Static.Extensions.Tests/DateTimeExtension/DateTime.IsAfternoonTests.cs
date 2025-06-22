namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_IsAfternoonTests
    {
        [Theory]
        [InlineData(2024, 6, 1, 11, 59, 59, false)]
        [InlineData(2024, 6, 1, 12, 0, 0, true)]
        [InlineData(2024, 6, 1, 15, 30, 0, true)]
        [InlineData(2024, 6, 1, 0, 0, 0, false)]
        [InlineData(2024, 6, 1, 23, 59, 59, true)]
        public void IsAfternoon_ReturnsExpectedResult(int year, int month, int day, int hour, int minute, int second, bool expected)
        {
            var dt = new DateTime(year, month, day, hour, minute, second, DateTimeKind.Unspecified);
            Assert.Equal(expected, dt.IsAfternoon());
        }

        [Fact]
        public void IsAfternoon_RespectsDateTimeKind()
        {
            var dtUtc = new DateTime(2024, 6, 1, 12, 0, 0, DateTimeKind.Utc);
            var dtLocal = new DateTime(2024, 6, 1, 12, 0, 0, DateTimeKind.Local);
            Assert.True(dtUtc.IsAfternoon());
            Assert.True(dtLocal.IsAfternoon());
        }
    }
}
