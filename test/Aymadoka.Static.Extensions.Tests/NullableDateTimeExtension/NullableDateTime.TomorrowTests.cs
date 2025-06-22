namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_TomorrowTests
    {
        [Fact]
        public void Tomorrow_WithNull_ReturnsNull()
        {
            DateTime? input = null;
            var result = NullableDateTimeExtensions.Tomorrow(input);
            Assert.Null(result);
        }

        [Fact]
        public void Tomorrow_WithValue_ReturnsNextDay()
        {
            DateTime? input = new DateTime(2024, 6, 1);
            var result = NullableDateTimeExtensions.Tomorrow(input);
            Assert.Equal(new DateTime(2024, 6, 2), result);
        }
    }
}
