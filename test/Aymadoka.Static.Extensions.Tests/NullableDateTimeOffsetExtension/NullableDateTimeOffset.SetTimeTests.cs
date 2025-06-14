namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public class NullableDateTimeOffset_SetTimeTests
    {
        [Fact]
        public void SetTime_HourOnly_ShouldSetHourAndResetOthers()
        {
            DateTimeOffset? dt = new DateTimeOffset(2024, 6, 1, 10, 30, 45, 123, TimeSpan.Zero);
            var result = dt.SetTime(8);
            Assert.NotNull(result);
            Assert.Equal(8, result.Value.Hour);
            Assert.Equal(0, result.Value.Minute);
            Assert.Equal(0, result.Value.Second);
            Assert.Equal(0, result.Value.Millisecond);
            Assert.Equal(dt.Value.Date, result.Value.Date);
            Assert.Equal(dt.Value.Offset, result.Value.Offset);
        }

        [Fact]
        public void SetTime_HourAndMinute_ShouldSetHourMinuteAndResetOthers()
        {
            DateTimeOffset? dt = new DateTimeOffset(2024, 6, 1, 10, 30, 45, 123, TimeSpan.FromHours(8));
            var result = dt.SetTime(15, 20);
            Assert.NotNull(result);
            Assert.Equal(15, result.Value.Hour);
            Assert.Equal(20, result.Value.Minute);
            Assert.Equal(0, result.Value.Second);
            Assert.Equal(0, result.Value.Millisecond);
            Assert.Equal(dt.Value.Date, result.Value.Date);
            Assert.Equal(dt.Value.Offset, result.Value.Offset);
        }

        [Fact]
        public void SetTime_HourMinuteSecond_ShouldSetHourMinuteSecondAndResetMillisecond()
        {
            DateTimeOffset? dt = new DateTimeOffset(2024, 6, 1, 10, 30, 45, 123, TimeSpan.FromHours(-5));
            var result = dt.SetTime(22, 59, 58);
            Assert.NotNull(result);
            Assert.Equal(22, result.Value.Hour);
            Assert.Equal(59, result.Value.Minute);
            Assert.Equal(58, result.Value.Second);
            Assert.Equal(0, result.Value.Millisecond);
            Assert.Equal(dt.Value.Date, result.Value.Date);
            Assert.Equal(dt.Value.Offset, result.Value.Offset);
        }

        [Fact]
        public void SetTime_AllFields_ShouldSetAllTimeFields()
        {
            DateTimeOffset? dt = new DateTimeOffset(2024, 6, 1, 10, 30, 45, 123, TimeSpan.FromMinutes(90));
            var result = dt.SetTime(1, 2, 3, 4);
            Assert.NotNull(result);
            Assert.Equal(1, result.Value.Hour);
            Assert.Equal(2, result.Value.Minute);
            Assert.Equal(3, result.Value.Second);
            Assert.Equal(4, result.Value.Millisecond);
            Assert.Equal(dt.Value.Date, result.Value.Date);
            Assert.Equal(dt.Value.Offset, result.Value.Offset);
        }

        [Fact]
        public void SetTime_NullInput_ShouldReturnNull()
        {
            DateTimeOffset? dt = null;
            Assert.Null(dt.SetTime(1));
            Assert.Null(dt.SetTime(1, 2));
            Assert.Null(dt.SetTime(1, 2, 3));
            Assert.Null(dt.SetTime(1, 2, 3, 4));
        }
    }
}