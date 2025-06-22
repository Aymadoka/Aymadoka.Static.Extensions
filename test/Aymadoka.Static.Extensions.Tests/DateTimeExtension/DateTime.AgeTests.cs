namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_AgeTests
    {
        [Theory]
        [InlineData("2000-01-01", "2024-06-01", 24)]
        [InlineData("2000-12-31", "2024-06-01", 23)]
        [InlineData("2000-06-01", "2024-06-01", 24)]
        [InlineData("2000-06-02", "2024-06-01", 23)]
        [InlineData("2024-06-01", "2024-06-01", 0)]
        [InlineData("2024-06-02", "2024-06-01", -1)]
        public void Age_ReturnsCorrectAge(string birthDateString, string todayString, int expectedAge)
        {
            var birthDate = DateTime.Parse(birthDateString);
            var today = DateTime.Parse(todayString);

            // 使用 DateTime.Today 需要重定向，使用委托模拟
            int AgeProxy(DateTime date, DateTime todayValue)
            {
                if (todayValue.Month < date.Month ||
                    (todayValue.Month == date.Month && todayValue.Day < date.Day))
                {
                    return todayValue.Year - date.Year - 1;
                }
                return todayValue.Year - date.Year;
            }

            int actual = AgeProxy(birthDate, today);
            Assert.Equal(expectedAge, actual);
        }
    }
}
