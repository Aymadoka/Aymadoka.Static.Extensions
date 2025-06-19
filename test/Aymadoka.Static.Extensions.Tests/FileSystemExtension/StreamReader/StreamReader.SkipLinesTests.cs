namespace Aymadoka.Static.StreamReaderExtension
{
    public class StreamReader_SkipLinesTests
    {
        [Fact]
        public void SkipLines_SkipsSpecifiedNumberOfLines()
        {
            // Arrange
            var text = "Line1\nLine2\nLine3\nLine4";
            using var reader = new StringReader(text);
            using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(text));
            using var streamReader = new StreamReader(stream);

            // Act
            streamReader.SkipLines(2);
            var result = streamReader.ReadLine();

            // Assert
            Assert.Equal("Line3", result);
        }

        [Fact]
        public void SkipLines_SkipCountGreaterThanLines_SetsEndOfStream()
        {
            // Arrange
            var text = "Line1\nLine2";
            using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(text));
            using var streamReader = new StreamReader(stream);

            // Act
            streamReader.SkipLines(5);
            var result = streamReader.ReadLine();

            // Assert
            Assert.Null(result);
            Assert.True(streamReader.EndOfStream);
        }

        [Fact]
        public void SkipLines_Zero_DoesNotSkipAnyLine()
        {
            // Arrange
            var text = "Line1\nLine2";
            using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(text));
            using var streamReader = new StreamReader(stream);

            // Act
            streamReader.SkipLines(0);
            var result = streamReader.ReadLine();

            // Assert
            Assert.Equal("Line1", result);
        }
    }
}
