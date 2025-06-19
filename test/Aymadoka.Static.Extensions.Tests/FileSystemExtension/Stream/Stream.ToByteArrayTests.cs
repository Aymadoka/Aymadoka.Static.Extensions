using System.Text;

namespace Aymadoka.Static.StreamExtension
{
    public class Stream_ToByteArrayTests
    {
        [Fact]
        public void ToByteArray_ReturnsCorrectBytes_ForNonEmptyStream()
        {
            // Arrange
            var expected = Encoding.UTF8.GetBytes("Hello, world!");
            using var stream = new MemoryStream(expected);

            // Act
            var result = stream.ToByteArray();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToByteArray_ReturnsEmptyArray_ForEmptyStream()
        {
            // Arrange
            using var stream = new MemoryStream();

            // Act
            var result = stream.ToByteArray();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void ToByteArray_DoesNotChangeStreamPosition()
        {
            // Arrange
            var data = Encoding.UTF8.GetBytes("Test");
            using var stream = new MemoryStream(data);
            stream.Position = 2;

            // Act
            var result = stream.ToByteArray();

            // Assert
            Assert.Equal(data, result);
            Assert.Equal(2, stream.Position);
        }

        [Fact]
        public void ToByteArray_ThrowsArgumentNullException_WhenStreamIsNull()
        {
            // Arrange
            Stream stream = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => stream.ToByteArray());
        }
    }
}
