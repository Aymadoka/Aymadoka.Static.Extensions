namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public class NullableDateTimeOffset_GetMonthFirstDayTests
    {
        [Fact]
        public void GetMonthFirstDay_NullInput_ReturnsNull()
        {
            DateTimeOffset? input = null;
            var result = input.GetMonthFirstDay();
            Assert.Null(result);
        }

        [Fact]
        public void GetMonthFirstDay_ValidInput_ReturnsFirstDayWithSameTime()
        {
            DateTimeOffset? input = new DateTimeOffset(2024, 6, 15, 13, 45, 30, TimeSpan.FromHours(8));
            var expected = new DateTimeOffset(2024, 6, 1, 13, 45, 30, TimeSpan.FromHours(8));
            var result = input.GetMonthFirstDay();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetMonthFirstDay_FirstDayInput_ReturnsSameValue()
        {
            DateTimeOffset? input = new DateTimeOffset(2024, 6, 1, 0, 0, 0, TimeSpan.Zero);
            var result = input.GetMonthFirstDay();
            Assert.Equal(input, result);
        }
    }
}
