namespace Aymadoka.Static.NullableDateTimeExtension
{
    public class NullableDateTime_ElapsedTests
    {
        [Fact]
        public void Elapsed_WithNonNullDateTime_ReturnsCorrectTimeSpan()
        {
            // Arrange
            var now = DateTime.UtcNow;
            DateTime? earlier = now.AddMinutes(-10);
            // Act
            var elapsed = earlier.Elapsed();
            // Assert
            Assert.True(elapsed.TotalMinutes >= 10 && elapsed.TotalMinutes < 11);
        }

        [Fact]
        public void Elapsed_WithNull_ThrowsArgumentNullException()
        {
            // Arrange
            DateTime? dt = null;
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => dt.Elapsed());
        }
    }
}
