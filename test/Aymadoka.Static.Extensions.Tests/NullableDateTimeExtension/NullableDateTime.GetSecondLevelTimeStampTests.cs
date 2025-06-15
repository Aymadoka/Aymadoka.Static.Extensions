namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_GetSecondLevelTimeStampTests
    {
        [Fact]
        public void GetSecondLevelTimeStamp_NullDate_ReturnsNull()
        {
            DateTime? date = null;
            var result = date.GetSecondLevelTimeStamp();
            Assert.Null(result);
        }

        [Fact]
        public void GetSecondLevelTimeStamp_EpochDate_ReturnsZero()
        {
            DateTime? date = DateTime.UnixEpoch;
            var result = date.GetSecondLevelTimeStamp();
            Assert.Equal(0, result);
        }

        [Fact]
        public void GetSecondLevelTimeStamp_SpecificDate_ReturnsCorrectTimestamp()
        {
            DateTime? date = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var expected = (long)(date.Value - DateTime.UnixEpoch).TotalSeconds;
            var result = date.GetSecondLevelTimeStamp();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetSecondLevelTimeStamp_LocalKindDate_ReturnsCorrectTimestamp()
        {
            DateTime? localDate = new DateTime(2024, 1, 1, 8, 0, 0, DateTimeKind.Local);
            var expected = (long)(localDate.Value - DateTime.UnixEpoch).TotalSeconds;
            var result = localDate.GetSecondLevelTimeStamp();
            Assert.Equal(expected, result);
        }
    }
}
