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
    }
}
