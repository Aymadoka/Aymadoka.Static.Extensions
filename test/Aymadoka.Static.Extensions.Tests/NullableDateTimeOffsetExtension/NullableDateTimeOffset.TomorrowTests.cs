namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public class NullableDateTimeOffset_TomorrowTests
    {
        [Fact]
        public void Tomorrow_ReturnsNull_WhenInputIsNull()
        {
            DateTimeOffset? input = null;
            var result = input.Tomorrow();
            Assert.Null(result);
        }

        [Fact]
        public void Tomorrow_ReturnsNextDay_WhenInputIsNotNull()
        {
            var now = new DateTimeOffset(2024, 6, 1, 12, 0, 0, TimeSpan.Zero);
            DateTimeOffset? input = now;
            var expected = now.AddDays(1);
            // 假设 DateTimeOffsetExtension.Tomorrow() 实现为 AddDays(1)
            var result = input.Tomorrow();
            Assert.Equal(expected, result);
        }
    }
}
