namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_BetweenTests
    {
        [Fact]
        public void Between_ReturnsTrue_WhenWithinRange()
        {
            var min = new DateTime(2024, 1, 1);
            var max = new DateTime(2024, 12, 31);
            var value = new DateTime(2024, 6, 1);

            Assert.True(value.Between(min, max));
        }

        [Fact]
        public void Between_ReturnsFalse_WhenEqualToMin()
        {
            var min = new DateTime(2024, 1, 1);
            var max = new DateTime(2024, 12, 31);
            var value = min;

            Assert.False(value.Between(min, max));
        }

        [Fact]
        public void Between_ReturnsFalse_WhenEqualToMax()
        {
            var min = new DateTime(2024, 1, 1);
            var max = new DateTime(2024, 12, 31);
            var value = max;

            Assert.False(value.Between(min, max));
        }

        [Fact]
        public void Between_ReturnsFalse_WhenLessThanMin()
        {
            var min = new DateTime(2024, 1, 1);
            var max = new DateTime(2024, 12, 31);
            var value = new DateTime(2023, 12, 31);

            Assert.False(value.Between(min, max));
        }

        [Fact]
        public void Between_ReturnsFalse_WhenGreaterThanMax()
        {
            var min = new DateTime(2024, 1, 1);
            var max = new DateTime(2024, 12, 31);
            var value = new DateTime(2025, 1, 1);

            Assert.False(value.Between(min, max));
        }
    }
}
