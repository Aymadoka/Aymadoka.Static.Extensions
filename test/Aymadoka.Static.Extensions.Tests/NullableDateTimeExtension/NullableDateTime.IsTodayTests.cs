namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_IsTodayTests
    {
        [Fact]
        public void IsToday_ReturnsFalse_WhenNull()
        {
            DateTime? value = null;
            Assert.False(value.IsToday());
        }

        [Fact]
        public void IsToday_ReturnsTrue_WhenToday()
        {
            DateTime? value = DateTime.Now;
            Assert.True(value.IsToday());
        }

        [Fact]
        public void IsToday_ReturnsFalse_WhenNotToday()
        {
            DateTime? value = DateTime.Now.AddDays(-1);
            Assert.False(value.IsToday());
        }
    }
}
