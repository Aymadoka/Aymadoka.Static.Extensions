namespace Aymadoka.Static.ByteArrayExtension
{
    public class ByteArray_ToMemoryStreamTests
    {
        [Fact]
        public void ToMemoryStream_WithValidByteArray_ReturnsMemoryStreamWithSameContent()
        {
            // Arrange
            byte[] data = { 1, 2, 3, 4, 5 };

            // Act
            using var stream = data.ToMemoryStream();

            // Assert
            Assert.NotNull(stream);
            Assert.True(stream.CanRead);
            Assert.Equal(data.Length, stream.Length);

            stream.Position = 0;
            var buffer = new byte[data.Length];
            int read = stream.Read(buffer, 0, buffer.Length);
            Assert.Equal(data.Length, read);
            Assert.Equal(data, buffer);
        }

        [Fact]
        public void ToMemoryStream_WithEmptyArray_ReturnsEmptyMemoryStream()
        {
            // Arrange
            byte[] data = Array.Empty<byte>();

            // Act
            using var stream = data.ToMemoryStream();

            // Assert
            Assert.NotNull(stream);
            Assert.Equal(0, stream.Length);
        }

        [Fact]
        public void ToMemoryStream_WithNull_ThrowsArgumentNullException()
        {
            // Arrange
            byte[] data = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => data.ToMemoryStream());
        }
    }
}
