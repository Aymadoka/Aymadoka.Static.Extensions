namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_SetTimeTests
    {
        [Fact]
        public void SetTime_HourOnly_ShouldSetHourAndResetOthers()
        {
            DateTime? dt = new DateTime(2024, 6, 1, 10, 30, 45, 123);
            var result = dt.SetTime(8);
            Assert.Equal(new DateTime(2024, 6, 1, 8, 0, 0, 0), result);
        }

        [Fact]
        public void SetTime_HourMinute_ShouldSetHourMinuteAndResetOthers()
        {
            DateTime? dt = new DateTime(2024, 6, 1, 10, 30, 45, 123);
            var result = dt.SetTime(9, 15);
            Assert.Equal(new DateTime(2024, 6, 1, 9, 15, 0, 0), result);
        }

        [Fact]
        public void SetTime_HourMinuteSecond_ShouldSetHourMinuteSecondAndResetMillisecond()
        {
            DateTime? dt = new DateTime(2024, 6, 1, 10, 30, 45, 123);
            var result = dt.SetTime(7, 20, 55);
            Assert.Equal(new DateTime(2024, 6, 1, 7, 20, 55, 0), result);
        }

        [Fact]
        public void SetTime_HourMinuteSecondMillisecond_ShouldSetAll()
        {
            DateTime? dt = new DateTime(2024, 6, 1, 10, 30, 45, 123);
            var result = dt.SetTime(6, 5, 4, 3);
            Assert.Equal(new DateTime(2024, 6, 1, 6, 5, 4, 3), result);
        }

        [Fact]
        public void SetTime_NullInput_ShouldReturnNull()
        {
            DateTime? dt = null;
            Assert.Null(dt.SetTime(1));
            Assert.Null(dt.SetTime(1, 2));
            Assert.Null(dt.SetTime(1, 2, 3));
            Assert.Null(dt.SetTime(1, 2, 3, 4));
        }
    }
}
