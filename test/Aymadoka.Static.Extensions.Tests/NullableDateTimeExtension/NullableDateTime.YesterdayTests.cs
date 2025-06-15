namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_YesterdayTests
    {
        [Fact]
        public void Yesterday_WithNull_ReturnsNull()
        {
            DateTime? input = null;
            var result = input.Yesterday();
            Assert.Null(result);
        }

        [Fact]
        public void Yesterday_WithValue_ReturnsPreviousDay()
        {
            DateTime? input = new DateTime(2024, 6, 10);
            var result = input.Yesterday();
            Assert.Equal(new DateTime(2024, 6, 9), result);
        }

        [Fact]
        public void Yesterday_WithMinValue_ThrowsArgumentOutOfRangeException()
        {
            DateTime? input = DateTime.MinValue;
            Assert.Throws<ArgumentOutOfRangeException>(() => input.Yesterday());
        }
    }
}
