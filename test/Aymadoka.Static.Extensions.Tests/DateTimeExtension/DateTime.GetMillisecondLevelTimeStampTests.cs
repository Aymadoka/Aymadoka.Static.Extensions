namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_GetMillisecondLevelTimeStampTests
    {
        [Fact]
        public void GetMillisecondLevelTimeStamp_Epoch_ReturnsZero()
        {
            var date = DateTime.UnixEpoch;
            var timestamp = date.GetMillisecondLevelTimeStamp();
            Assert.Equal(0, timestamp);
        }

        [Fact]
        public void GetMillisecondLevelTimeStamp_OneSecondAfterEpoch_Returns1000()
        {
            var date = DateTime.UnixEpoch.AddSeconds(1);
            var timestamp = date.GetMillisecondLevelTimeStamp();
            Assert.Equal(1000, timestamp);
        }

        [Fact]
        public void GetMillisecondLevelTimeStamp_OneMillisecondAfterEpoch_Returns1()
        {
            var date = DateTime.UnixEpoch.AddMilliseconds(1);
            var timestamp = date.GetMillisecondLevelTimeStamp();
            Assert.Equal(1, timestamp);
        }

        [Fact]
        public void GetMillisecondLevelTimeStamp_BeforeEpoch_ReturnsNegative()
        {
            var date = DateTime.UnixEpoch.AddMilliseconds(-500);
            var timestamp = date.GetMillisecondLevelTimeStamp();
            Assert.Equal(-500, timestamp);
        }

        [Fact]
        public void GetMillisecondLevelTimeStamp_LocalTime_HandlesKindCorrectly()
        {
            var utcDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var localDate = utcDate.ToLocalTime();
            var utcTimestamp = utcDate.GetMillisecondLevelTimeStamp();
            var localTimestamp = localDate.GetMillisecondLevelTimeStamp();
            Assert.NotEqual(utcTimestamp, localTimestamp);
        }
    }
}
