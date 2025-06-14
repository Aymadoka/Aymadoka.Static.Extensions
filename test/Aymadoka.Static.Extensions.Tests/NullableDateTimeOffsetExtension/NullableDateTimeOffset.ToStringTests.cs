namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public class NullableDateTimeOffset_ToStringTests
    {
        [Fact]
        public void ToString_WithNull_ReturnsNull()
        {
            DateTimeOffset? value = null;
            var result = value.ToString("yyyy-MM-dd");
            Assert.Null(result);
        }

        [Fact]
        public void ToString_WithValueAndFormat_ReturnsFormattedString()
        {
            DateTimeOffset? value = new DateTimeOffset(2024, 6, 1, 12, 34, 56, TimeSpan.Zero);
            var result = value.ToString("yyyy-MM-dd HH:mm:ss");
            Assert.Equal("2024-06-01 12:34:56", result);
        }

        [Fact]
        public void ToString_WithValueAndNullFormat_ReturnsDefaultString()
        {
            DateTimeOffset? value = new DateTimeOffset(2024, 6, 1, 12, 34, 56, TimeSpan.Zero);
            string format = null;
            var result = value.ToString(format);
            Assert.Equal(value.Value.ToString(format), result);
        }
    }
}
