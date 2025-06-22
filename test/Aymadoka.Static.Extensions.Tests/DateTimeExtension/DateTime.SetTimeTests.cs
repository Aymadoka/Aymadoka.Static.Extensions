namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_SetTimeTests
    {
        [Fact]
        public void SetTime_HourOnly_SetsHourAndResetsOthers()
        {
            var dt = new DateTime(2024, 6, 1, 12, 34, 56, 789, DateTimeKind.Local);
            var result = dt.SetTime(8);
            Assert.Equal(new DateTime(2024, 6, 1, 8, 0, 0, 0, DateTimeKind.Local), result);
        }

        [Fact]
        public void SetTime_HourAndMinute_SetsHourMinuteAndResetsOthers()
        {
            var dt = new DateTime(2024, 6, 1, 12, 34, 56, 789, DateTimeKind.Utc);
            var result = dt.SetTime(9, 15);
            Assert.Equal(new DateTime(2024, 6, 1, 9, 15, 0, 0, DateTimeKind.Utc), result);
        }

        [Fact]
        public void SetTime_HourMinuteSecond_SetsHourMinuteSecondAndResetsMillisecond()
        {
            var dt = new DateTime(2024, 6, 1, 12, 34, 56, 789, DateTimeKind.Unspecified);
            var result = dt.SetTime(10, 20, 30);
            Assert.Equal(new DateTime(2024, 6, 1, 10, 20, 30, 0, DateTimeKind.Unspecified), result);
        }

        [Fact]
        public void SetTime_AllParameters_SetsAllTimeParts()
        {
            var dt = new DateTime(2024, 6, 1, 12, 34, 56, 789, DateTimeKind.Local);
            var result = dt.SetTime(1, 2, 3, 4);
            Assert.Equal(new DateTime(2024, 6, 1, 1, 2, 3, 4, DateTimeKind.Local), result);
        }

        [Fact]
        public void SetTime_PreservesDateAndKind()
        {
            var dt = new DateTime(2020, 2, 29, 23, 59, 59, 999, DateTimeKind.Utc);
            var result = dt.SetTime(0, 0, 0, 0);
            Assert.Equal(new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Utc), result);
        }
    }
}
