namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_GetMillisecondLevelTimeStampTests
    {
        [Fact]
        public void GetMillisecondLevelTimeStamp_NullDate_ReturnsNull()
        {
            DateTime? date = null;
            var result = date.GetMillisecondLevelTimeStamp();
            Assert.Null(result);
        }

        [Fact]
        public void GetMillisecondLevelTimeStamp_UnixEpoch_ReturnsZero()
        {
            DateTime? date = DateTime.UnixEpoch;
            var result = date.GetMillisecondLevelTimeStamp();
            Assert.Equal(0, result);
        }

        [Fact]
        public void GetMillisecondLevelTimeStamp_SpecificDate_ReturnsCorrectMilliseconds()
        {
            DateTime? date = DateTime.UnixEpoch.AddMilliseconds(123456789);
            var result = date.GetMillisecondLevelTimeStamp();
            Assert.Equal(123456789, result);
        }

        [Fact]
        public void GetMillisecondLevelTimeStamp_BeforeUnixEpoch_ReturnsNegativeMilliseconds()
        {
            DateTime? date = DateTime.UnixEpoch.AddMilliseconds(-1000);
            var result = date.GetMillisecondLevelTimeStamp();
            Assert.Equal(-1000, result);
        }
    }
}
