namespace Aymadoka.Static.NullableDateTimeOffsetExtension
{
    public class NullableDateTimeOffset_ToEpochTimeSpanTests
    {
        [Fact]
        public void ToEpochTimeSpan_NullInput_ReturnsNull()
        {
            DateTimeOffset? input = null;
            var result = input.ToEpochTimeSpan();
            Assert.Null(result);
        }

        [Fact]
        public void ToEpochTimeSpan_ValidInput_ReturnsCorrectTimeSpan()
        {
            // Arrange
            DateTimeOffset? date = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
            DateTimeOffset? input = date;
            var expected = date.ToEpochTimeSpan();

            // Act
            var result = input.ToEpochTimeSpan();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
