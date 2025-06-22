namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_GetSecondLevelTimeStampTests
    {
        [Fact]
        public void GetSecondLevelTimeStamp_ShouldReturnZero_ForUnixEpoch()
        {
            var date = DateTime.UnixEpoch;
            var timestamp = date.GetSecondLevelTimeStamp();
            Assert.Equal(0, timestamp);
        }

        [Fact]
        public void GetSecondLevelTimeStamp_ShouldReturnCorrectValue_ForKnownDate()
        {
            var date = new DateTime(1970, 1, 1, 0, 0, 1, DateTimeKind.Utc);
            var timestamp = date.GetSecondLevelTimeStamp();
            Assert.Equal(1, timestamp);
        }

        [Fact]
        public void GetSecondLevelTimeStamp_ShouldHandleLocalTime()
        {
            var utcDate = DateTime.UnixEpoch;
            var localDate = DateTime.SpecifyKind(utcDate.ToLocalTime(), DateTimeKind.Local);
            var timestampUtc = utcDate.GetSecondLevelTimeStamp();
            var timestampLocal = localDate.GetSecondLevelTimeStamp();
            Assert.Equal(timestampUtc, timestampLocal);
        }

        [Fact]
        public void GetSecondLevelTimeStamp_ShouldReturnNegative_ForDateBeforeEpoch()
        {
            var date = new DateTime(1969, 12, 31, 23, 59, 59, DateTimeKind.Utc);
            var timestamp = date.GetSecondLevelTimeStamp();
            Assert.Equal(-1, timestamp);
        }
    }
}
