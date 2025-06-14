namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_GetMonthFirstDayTests
    {
        [Fact]
        public void GetMonthFirstDay_NullInput_ReturnsNull()
        {
            DateTime? input = null;
            var result = input.GetMonthFirstDay();
            Assert.Null(result);
        }

        [Fact]
        public void GetMonthFirstDay_ValidDate_ReturnsFirstDayOfMonth()
        {
            DateTime? input = new DateTime(2024, 6, 15, 10, 30, 0);
            var result = input.GetMonthFirstDay();
            Assert.NotNull(result);
            Assert.Equal(new DateTime(2024, 6, 1), result.Value.Date);
        }

        [Fact]
        public void GetMonthFirstDay_AlreadyFirstDay_ReturnsSameDay()
        {
            DateTime? input = new DateTime(2023, 12, 1);
            var result = input.GetMonthFirstDay();
            Assert.NotNull(result);
            Assert.Equal(new DateTime(2023, 12, 1), result.Value.Date);
        }
    }
}
