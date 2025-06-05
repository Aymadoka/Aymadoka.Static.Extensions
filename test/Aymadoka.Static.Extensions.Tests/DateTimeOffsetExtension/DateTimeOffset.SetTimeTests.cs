namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_SetTimeTests
    {
        [Fact]
        public void SetTime_HourOnly_SetsHourAndResetsOthers()
        {
            var original = new DateTimeOffset(2024, 6, 1, 15, 30, 45, 123, TimeSpan.FromHours(8));
            var result = original.SetTime(10);
            Assert.Equal(2024, result.Year);
            Assert.Equal(6, result.Month);
            Assert.Equal(1, result.Day);
            Assert.Equal(10, result.Hour);
            Assert.Equal(0, result.Minute);
            Assert.Equal(0, result.Second);
            Assert.Equal(0, result.Millisecond);
            Assert.Equal(original.Offset, result.Offset);
        }

        [Fact]
        public void SetTime_HourAndMinute_SetsHourMinuteAndResetsOthers()
        {
            var original = new DateTimeOffset(2024, 6, 1, 15, 30, 45, 123, TimeSpan.FromHours(8));
            var result = original.SetTime(8, 20);
            Assert.Equal(8, result.Hour);
            Assert.Equal(20, result.Minute);
            Assert.Equal(0, result.Second);
            Assert.Equal(0, result.Millisecond);
        }

        [Fact]
        public void SetTime_HourMinuteSecond_SetsHourMinuteSecondAndResetsMillisecond()
        {
            var original = new DateTimeOffset(2024, 6, 1, 15, 30, 45, 123, TimeSpan.FromHours(8));
            var result = original.SetTime(7, 10, 59);
            Assert.Equal(7, result.Hour);
            Assert.Equal(10, result.Minute);
            Assert.Equal(59, result.Second);
            Assert.Equal(0, result.Millisecond);
        }

        [Fact]
        public void SetTime_AllParameters_SetsAllTimeParts()
        {
            var original = new DateTimeOffset(2024, 6, 1, 15, 30, 45, 123, TimeSpan.FromHours(8));
            var result = original.SetTime(1, 2, 3, 4);
            Assert.Equal(1, result.Hour);
            Assert.Equal(2, result.Minute);
            Assert.Equal(3, result.Second);
            Assert.Equal(4, result.Millisecond);
        }

        [Fact]
        public void SetTime_OffsetIsPreserved()
        {
            var original = new DateTimeOffset(2024, 6, 1, 15, 30, 45, 123, TimeSpan.FromHours(-5));
            var result = original.SetTime(12, 0, 0, 0);
            Assert.Equal(original.Offset, result.Offset);
        }
    }
}
