namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_IsAfternoonTests
    {
        [Theory]
        [InlineData(2024, 6, 1, 13, 0, 0, true)]   // 下午1点
        [InlineData(2024, 6, 1, 12, 0, 0, true)]  // 中午12点
        [InlineData(2024, 6, 1, 11, 59, 59, false)]// 上午
        [InlineData(2024, 6, 1, 23, 59, 59, true)] // 晚上
        public void IsAfternoon_ReturnsExpectedResult(int year, int month, int day, int hour, int minute, int second, bool expected)
        {
            DateTime? dt = new DateTime(year, month, day, hour, minute, second);
            var result = dt.IsAfternoon();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsAfternoon_Null_ReturnsFalse()
        {
            DateTime? dt = null;
            var result = dt.IsAfternoon();
            Assert.False(result);
        }
    }
}
