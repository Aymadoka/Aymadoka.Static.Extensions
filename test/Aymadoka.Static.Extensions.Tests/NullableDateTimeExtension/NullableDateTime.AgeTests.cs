namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_AgeTests
    {
        [Fact]
        public void Age_NullInput_ReturnsNull()
        {
            DateTime? input = null;
            var result = input.Age();
            Assert.Null(result);
        }

        [Fact]
        public void Age_BirthdayToday_ReturnsZero()
        {
            DateTime? input = DateTime.Today;
            var result = input.Age();
            Assert.Equal(0, result);
        }

        [Fact]
        public void Age_BirthdayInPast_ReturnsCorrectAge()
        {
            var years = 25;
            DateTime? input = DateTime.Today.AddYears(-years);
            var result = input.Age();
            Assert.Equal(years, result);
        }

        [Fact]
        public void Age_BirthdayNotYetThisYear_ReturnsAgeMinusOne()
        {
            var years = 30;
            var birthday = DateTime.Today.AddYears(-years).AddDays(1);
            DateTime? input = birthday;
            var result = input.Age();
            Assert.Equal(years - 1, result);
        }
    }
}
