namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_IsFutureTests
    {
        [Fact]
        public void IsFuture_Null_ReturnsFalse()
        {
            DateTime? dt = null;
            Assert.False(dt.IsFuture());
        }

        [Fact]
        public void IsFuture_PastDate_ReturnsFalse()
        {
            DateTime? dt = DateTime.Now.AddMinutes(-10);
            Assert.False(dt.IsFuture());
        }

        [Fact]
        public void IsFuture_Now_ReturnsFalse()
        {
            DateTime? dt = DateTime.Now;
            Assert.False(dt.IsFuture());
        }

        [Fact]
        public void IsFuture_FutureDate_ReturnsTrue()
        {
            DateTime? dt = DateTime.Now.AddMinutes(10);
            Assert.True(dt.IsFuture());
        }
    }
}
