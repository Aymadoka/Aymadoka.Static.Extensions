namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_ToStringTests
    {
        [Fact]
        public void ToString_NullInput_ReturnsNull()
        {
            DateTime? input = null;
            var result = input.ToString("yyyy-MM-dd");
            Assert.Null(result);
        }

        [Fact]
        public void ToString_ValidDate_ReturnsFormattedString()
        {
            DateTime? input = new DateTime(2024, 6, 1, 15, 30, 45);
            var result = input.ToString("yyyy-MM-dd HH:mm:ss");
            Assert.Equal("2024-06-01 15:30:45", result);
        }

        [Fact]
        public void ToString_ValidDate_NullFormat_ReturnsDefaultFormat()
        {
            DateTime? input = new DateTime(2024, 6, 1, 15, 30, 45);
            var result = input.ToString(null);
            Assert.Equal(input.Value.ToString(), result);
        }
    }
}
