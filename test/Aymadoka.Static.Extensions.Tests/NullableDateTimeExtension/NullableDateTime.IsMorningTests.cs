namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_IsMorningTests
    {
        [Theory]
        [InlineData(2024, 6, 1, 0, 0, true)]
        [InlineData(2024, 6, 1, 11, 59, true)]
        [InlineData(2024, 6, 1, 12, 0, false)]
        [InlineData(2024, 6, 1, 23, 59, false)]
        public void IsMorning_ReturnsExpectedResult(int year, int month, int day, int hour, int minute, bool expected)
        {
            DateTime? dt = new DateTime(year, month, day, hour, minute, 0);
            Assert.Equal(expected, dt.IsMorning());
        }

        [Fact]
        public void IsMorning_Null_ReturnsFalse()
        {
            DateTime? dt = null;
            Assert.False(dt.IsMorning());
        }
    }
}
