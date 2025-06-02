namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_RemoveTimeTests
    {
        [Fact]
        public void RemoveTime_ShouldReturnDateWithZeroTime()
        {
            // Arrange
            var dateTime = new DateTime(2024, 6, 1, 15, 30, 45);

            // Act
            var result = dateTime.RemoveTime();

            // Assert
            Assert.Equal(new DateTime(2024, 6, 1, 0, 0, 0), result);
        }

        [Fact]
        public void RemoveTime_ShouldPreserveDate()
        {
            // Arrange
            var dateTime = new DateTime(1999, 12, 31, 23, 59, 59);

            // Act
            var result = dateTime.RemoveTime();

            // Assert
            Assert.Equal(1999, result.Year);
            Assert.Equal(12, result.Month);
            Assert.Equal(31, result.Day);
            Assert.Equal(0, result.Hour);
            Assert.Equal(0, result.Minute);
            Assert.Equal(0, result.Second);
        }
    }
}
