namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_ToEpochTimeSpanTests
    {
        [Fact]
        public void ToEpochTimeSpan_NullInput_ReturnsNull()
        {
            DateTime? input = null;
            var result = input.ToEpochTimeSpan();
            Assert.Null(result);
        }

        [Fact]
        public void ToEpochTimeSpan_ValidDateTime_ReturnsExpectedTimeSpan()
        {
            // 假设 ToEpochTimeSpan() 以 Unix 纪元为基准
            DateTime? input = new DateTime(1970, 1, 2, 0, 0, 0, DateTimeKind.Utc);
            // 需要确保 Aymadoka.Static.DateTimeExtension.ToEpochTimeSpan() 的实现是以 Unix 纪元为基准
            var expected = TimeSpan.FromDays(1);
            var result = input.ToEpochTimeSpan();
            Assert.Equal(expected, result);
        }
    }
}
