namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public class NullableDateTimeOffset_RemoveTimeTests
    {
        [Fact]
        public void RemoveTime_NullInput_ReturnsNull()
        {
            DateTimeOffset? input = null;
            var result = input.RemoveTime();
            Assert.Null(result);
        }

        [Fact]
        public void RemoveTime_WithTimePart_RemovesTime()
        {
            DateTimeOffset? input = new DateTimeOffset(2024, 6, 1, 15, 30, 45, TimeSpan.FromHours(8));
            var expected = new DateTimeOffset(2024, 6, 1, 0, 0, 0, TimeSpan.FromHours(8));
            var result = input.RemoveTime();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RemoveTime_AlreadyDateOnly_ReturnsSameDate()
        {
            DateTimeOffset? input = new DateTimeOffset(2024, 6, 1, 0, 0, 0, TimeSpan.Zero);
            var result = input.RemoveTime();
            Assert.Equal(input, result);
        }
    }
}
