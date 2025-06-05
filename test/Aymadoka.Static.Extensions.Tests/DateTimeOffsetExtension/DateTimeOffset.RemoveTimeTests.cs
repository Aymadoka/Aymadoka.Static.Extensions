namespace Aymadoka.Static.DateTimeOffsetExtension
{
    public class DateTimeOffset_RemoveTimeTests
    {
        [Fact]
        public void RemoveTime_Should_Remove_TimePart()
        {
            // Arrange
            var dateTime = new DateTimeOffset(2024, 6, 1, 15, 30, 45, TimeSpan.FromHours(8));

            // Act
            var result = dateTime.RemoveTime();

            // Assert
            Assert.Equal(new DateTimeOffset(2024, 6, 1, 0, 0, 0, TimeSpan.FromHours(8)), result);
        }

        [Fact]
        public void RemoveTime_Should_Not_Change_Offset()
        {
            // Arrange
            var dateTime = new DateTimeOffset(2023, 12, 31, 23, 59, 59, TimeSpan.FromHours(-5));

            // Act
            var result = dateTime.RemoveTime();

            // Assert
            Assert.Equal(TimeSpan.FromHours(-5), result.Offset);
        }

        [Fact]
        public void RemoveTime_Should_Work_For_Midnight()
        {
            // Arrange
            var dateTime = new DateTimeOffset(2022, 1, 1, 0, 0, 0, TimeSpan.Zero);

            // Act
            var result = dateTime.RemoveTime();

            // Assert
            Assert.Equal(dateTime, result);
        }
    }
}
