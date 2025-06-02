namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_IsTimeEqualTests
    {
        [Fact]
        public void IsTimeEqual_SameTime_ReturnsTrue()
        {
            var dt1 = new DateTime(2024, 6, 1, 12, 30, 45);
            var dt2 = new DateTime(2020, 1, 1, 12, 30, 45);
            Assert.True(dt1.IsTimeEqual(dt2));
        }

        [Fact]
        public void IsTimeEqual_DifferentTime_ReturnsFalse()
        {
            var dt1 = new DateTime(2024, 6, 1, 12, 30, 45);
            var dt2 = new DateTime(2024, 6, 1, 13, 30, 45);
            Assert.False(dt1.IsTimeEqual(dt2));
        }

        [Fact]
        public void IsTimeEqual_DifferentSeconds_ReturnsFalse()
        {
            var dt1 = new DateTime(2024, 6, 1, 12, 30, 45);
            var dt2 = new DateTime(2024, 6, 1, 12, 30, 46);
            Assert.False(dt1.IsTimeEqual(dt2));
        }

        [Fact]
        public void IsTimeEqual_DifferentMilliseconds_ReturnsFalse()
        {
            var dt1 = new DateTime(2024, 6, 1, 12, 30, 45, 100);
            var dt2 = new DateTime(2024, 6, 1, 12, 30, 45, 101);
            Assert.False(dt1.IsTimeEqual(dt2));
        }

        [Fact]
        public void IsTimeEqual_SameTimeWithDifferentDate_ReturnsTrue()
        {
            var dt1 = new DateTime(2022, 5, 10, 8, 15, 0);
            var dt2 = new DateTime(2023, 7, 20, 8, 15, 0);
            Assert.True(dt1.IsTimeEqual(dt2));
        }
    }
}
