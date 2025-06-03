namespace Aymadoka.Static.DateTimeExtension
{
    public class DateTime_ElapsedTests
    {
        [Fact]
        public void Elapsed_ShouldReturnCorrectTimeSpan_ForPastDateTime()
        {
            // Arrange
            var now = DateTime.UtcNow;
            var past = now.AddMinutes(-10);

            // Act
            var elapsed = past.Elapsed();

            // Assert
            Assert.True(elapsed.TotalMinutes >= 10 && elapsed.TotalMinutes < 10.1);
        }

        [Fact]
        public void Elapsed_ShouldReturnNegativeTimeSpan_ForFutureDateTime()
        {
            // Arrange
            var now = DateTime.UtcNow;
            var future = now.AddMinutes(5);

            // Act
            var elapsed = future.Elapsed();

            // Assert
            Assert.True(elapsed.TotalMinutes >= -5 && elapsed.TotalMinutes <= -4.9);
        }

        [Fact]
        public void Elapsed_ShouldReturnZero_ForCurrentUtcNow()
        {
            // Arrange
            var now = DateTime.UtcNow;

            // Act
            var elapsed = now.Elapsed();

            // Assert
            Assert.True(Math.Abs(elapsed.TotalMilliseconds) < 10);
        }
    }
}
