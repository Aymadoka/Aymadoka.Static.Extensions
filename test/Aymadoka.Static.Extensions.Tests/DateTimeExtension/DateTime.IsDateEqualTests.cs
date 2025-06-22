namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_IsDateEqualTests
    {
        [Fact]
        public void IsDateEqual_SameDateDifferentTime_ReturnsTrue()
        {
            var date1 = new DateTime(2024, 6, 1, 8, 0, 0);
            var date2 = new DateTime(2024, 6, 1, 18, 30, 0);

            Assert.True(date1.IsDateEqual(date2));
        }

        [Fact]
        public void IsDateEqual_DifferentDate_ReturnsFalse()
        {
            var date1 = new DateTime(2024, 6, 1);
            var date2 = new DateTime(2024, 6, 2);

            Assert.False(date1.IsDateEqual(date2));
        }

        [Fact]
        public void IsDateEqual_SameDateSameTime_ReturnsTrue()
        {
            var date1 = new DateTime(2024, 6, 1, 12, 0, 0);
            var date2 = new DateTime(2024, 6, 1, 12, 0, 0);

            Assert.True(date1.IsDateEqual(date2));
        }

        [Fact]
        public void IsDateEqual_DifferentMonth_ReturnsFalse()
        {
            var date1 = new DateTime(2024, 5, 31);
            var date2 = new DateTime(2024, 6, 1);

            Assert.False(date1.IsDateEqual(date2));
        }

        [Fact]
        public void IsDateEqual_DifferentYear_ReturnsFalse()
        {
            var date1 = new DateTime(2023, 6, 1);
            var date2 = new DateTime(2024, 6, 1);

            Assert.False(date1.IsDateEqual(date2));
        }
    }
}
