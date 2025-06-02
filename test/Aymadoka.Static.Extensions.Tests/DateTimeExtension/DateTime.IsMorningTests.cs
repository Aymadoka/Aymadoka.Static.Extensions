namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_IsMorningTests
    {
        [Theory]
        [InlineData(2024, 6, 1, 0, 0, 0, true)]    // 午夜
        [InlineData(2024, 6, 1, 11, 59, 59, true)] // 上午最后一秒
        [InlineData(2024, 6, 1, 12, 0, 0, false)]  // 中午
        [InlineData(2024, 6, 1, 15, 30, 0, false)] // 下午
        [InlineData(2024, 6, 1, 23, 59, 59, false)]// 深夜
        public void IsMorning_ReturnsExpectedResult(int year, int month, int day, int hour, int minute, int second, bool expected)
        {
            var dt = new DateTime(year, month, day, hour, minute, second, DateTimeKind.Local);
            Assert.Equal(expected, dt.IsMorning());
        }

        [Fact]
        public void IsMorning_RespectsDateTimeKind()
        {
            var local = new DateTime(2024, 6, 1, 8, 0, 0, DateTimeKind.Local);
            var utc = new DateTime(2024, 6, 1, 8, 0, 0, DateTimeKind.Utc);
            var unspecified = new DateTime(2024, 6, 1, 8, 0, 0, DateTimeKind.Unspecified);

            Assert.True(local.IsMorning());
            Assert.True(utc.IsMorning());
            Assert.True(unspecified.IsMorning());
        }
    }
}
