namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_ToEpochTimeSpanTests
    {
        [Fact]
        public void ToEpochTimeSpan_ReturnsZero_ForUnixEpoch()
        {
            var dt = DateTime.UnixEpoch;
            var span = dt.ToEpochTimeSpan();
            Assert.Equal(TimeSpan.Zero, span);
        }

        [Fact]
        public void ToEpochTimeSpan_ReturnsPositive_ForAfterUnixEpoch()
        {
            var dt = DateTime.UnixEpoch.AddSeconds(12345);
            var span = dt.ToEpochTimeSpan();
            Assert.Equal(TimeSpan.FromSeconds(12345), span);
        }

        [Fact]
        public void ToEpochTimeSpan_ReturnsNegative_ForBeforeUnixEpoch()
        {
            var dt = DateTime.UnixEpoch.AddSeconds(-12345);
            var span = dt.ToEpochTimeSpan();
            Assert.Equal(TimeSpan.FromSeconds(-12345), span);
        }

        [Fact]
        public void ToEpochTimeSpan_HandlesDifferentKinds()
        {
            var utc = new DateTime(1970, 1, 2, 0, 0, 0, DateTimeKind.Utc);
            var local = new DateTime(1970, 1, 2, 0, 0, 0, DateTimeKind.Local);
            var unspecified = new DateTime(1970, 1, 2, 0, 0, 0, DateTimeKind.Unspecified);

            Assert.Equal(TimeSpan.FromDays(1), utc.ToEpochTimeSpan());
            // Local/Unspecified: result depends on system time zone, so just check type
            Assert.IsType<TimeSpan>(local.ToEpochTimeSpan());
            Assert.IsType<TimeSpan>(unspecified.ToEpochTimeSpan());
        }
    }
}
