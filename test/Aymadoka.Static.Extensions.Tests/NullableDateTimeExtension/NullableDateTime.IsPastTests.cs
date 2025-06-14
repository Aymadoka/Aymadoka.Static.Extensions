namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_IsPastTests
    {
        [Fact]
        public void IsPast_ShouldReturnFalse_WhenNull()
        {
            DateTime? dt = null;
            Assert.False(dt.IsPast());
        }

        [Fact]
        public void IsPast_ShouldReturnTrue_WhenPastDate()
        {
            DateTime? dt = DateTime.Now.AddMinutes(-1);
            Assert.True(dt.IsPast());
        }

        [Fact]
        public void IsPast_ShouldReturnFalse_WhenFutureDate()
        {
            DateTime? dt = DateTime.Now.AddMinutes(1);
            Assert.False(dt.IsPast());
        }

        [Fact]
        public void IsPast_ShouldReturnFalse_WhenNow()
        {
            DateTime? dt = DateTime.Now;
            // 由于IsPast的实现依赖于DateTime.IsPast()，此处假设IsPast()对当前时间返回false
            Assert.False(dt.IsPast());
        }
    }
}
