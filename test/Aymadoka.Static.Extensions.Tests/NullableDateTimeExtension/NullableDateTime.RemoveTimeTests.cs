namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_RemoveTimeTests
    {
        [Fact]
        public void RemoveTime_NullInput_ReturnsNull()
        {
            DateTime? input = null;
            var result = input.RemoveTime();
            Assert.Null(result);
        }

        [Fact]
        public void RemoveTime_WithTimePart_RemovesTime()
        {
            DateTime? input = new DateTime(2024, 6, 1, 15, 30, 45);
            var result = input.RemoveTime();
            Assert.NotNull(result);
            Assert.Equal(new DateTime(2024, 6, 1), result);
        }

        [Fact]
        public void RemoveTime_AlreadyDateOnly_ReturnsSameDate()
        {
            DateTime? input = new DateTime(2024, 6, 1);
            var result = input.RemoveTime();
            Assert.NotNull(result);
            Assert.Equal(new DateTime(2024, 6, 1), result);
        }
    }
}
