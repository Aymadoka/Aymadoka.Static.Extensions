namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public class NullableDateTimeOffset_YesterdayTests
    {
        [Fact]
        public void Yesterday_ReturnsNull_WhenInputIsNull()
        {
            DateTimeOffset? input = null;
            var result = NullableDateTimeOffsetExtensions.Yesterday(input);
            Assert.Null(result);
        }

        [Fact]
        public void Yesterday_ReturnsPreviousDay_WhenInputIsNotNull()
        {
            var now = new DateTimeOffset(2024, 6, 1, 12, 0, 0, TimeSpan.Zero);
            var expected = now.AddDays(-1);
            DateTimeOffset? input = now;
            var result = NullableDateTimeOffsetExtensions.Yesterday(input);
            Assert.Equal(expected, result);
        }
    }
}
