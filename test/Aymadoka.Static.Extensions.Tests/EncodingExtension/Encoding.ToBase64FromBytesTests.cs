using System.Text;

namespace Aymadoka.Static.EncodingExtension
{
    public class Encoding_ToBase64FromBytesTests
    {
        [Fact]
        public void ToBase64FromBytes_Should_Convert_Bytes_To_Base64()
        {
            // Arrange
            var bytes = Encoding.UTF8.GetBytes("hello");

            // Act
            var result = bytes.ToBase64FromBytes();

            // Assert
            Assert.Equal("aGVsbG8=", result);
        }

        [Fact]
        public void ToBase64FromBytes_WithOptions_Should_Convert_Bytes_To_Base64()
        {
            // Arrange
            var bytes = Encoding.UTF8.GetBytes("hello world");

            // Act
            var result = bytes.ToBase64FromBytes(Base64FormattingOptions.InsertLineBreaks);

            // Assert
            Assert.Contains("aGVsbG8gd29ybGQ=", result.Replace(Environment.NewLine, ""));
        }

        [Fact]
        public void ToBase64FromBytes_WithOffsetAndLength_Should_Convert_Partial_Bytes()
        {
            // Arrange
            var bytes = Encoding.UTF8.GetBytes("abcdef");

            // Act
            var result = bytes.ToBase64FromBytes(1, 3); // "bcd"

            // Assert
            Assert.Equal("YmNk", result);
        }

        [Fact]
        public void ToBase64FromBytes_WithOffsetLengthAndOptions_Should_Convert_Partial_Bytes()
        {
            // Arrange
            var bytes = Encoding.UTF8.GetBytes("abcdef");

            // Act
            var result = bytes.ToBase64FromBytes(2, 4, Base64FormattingOptions.None); // "cdef"

            // Assert
            Assert.Equal("Y2RlZg==", result);
        }

        [Fact]
        public void ToBase64FromBytes_ThrowsArgumentNullException_WhenArrayIsNull()
        {
            byte[] data = null;
            Assert.Throws<ArgumentNullException>(() => EncodingExtensions.ToBase64FromBytes(data));
            Assert.Throws<ArgumentNullException>(() => EncodingExtensions.ToBase64FromBytes(data, Base64FormattingOptions.None));
            Assert.Throws<ArgumentNullException>(() => EncodingExtensions.ToBase64FromBytes(data, 0, 0));
            Assert.Throws<ArgumentNullException>(() => EncodingExtensions.ToBase64FromBytes(data, 0, 0, Base64FormattingOptions.None));
        }

        [Fact]
        public void ToBase64FromBytes_ThrowsArgumentNullException_WhenArrayIsEmpty()
        {
            byte[] data = Array.Empty<byte>();
            Assert.Throws<ArgumentNullException>(() => EncodingExtensions.ToBase64FromBytes(data));
            Assert.Throws<ArgumentNullException>(() => EncodingExtensions.ToBase64FromBytes(data, Base64FormattingOptions.None));
            Assert.Throws<ArgumentNullException>(() => EncodingExtensions.ToBase64FromBytes(data, 0, 0));
            Assert.Throws<ArgumentNullException>(() => EncodingExtensions.ToBase64FromBytes(data, 0, 0, Base64FormattingOptions.None));
        }

        [Fact]
        public void ToBase64FromBytes_Should_Throw_On_Null_Or_Empty()
        {
            // Arrange
            byte[] nullBytes = null;
            byte[] emptyBytes = new byte[0];

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => nullBytes.ToBase64FromBytes());
            Assert.Throws<ArgumentNullException>(() => emptyBytes.ToBase64FromBytes());
        }

        [Fact]
        public void ToBase64FromBytes_WithValidBytesAndOptions_ReturnsExpectedBase64()
        {
            // Arrange
            byte[] bytes = Encoding.UTF8.GetBytes("hello world");
            var expected = Convert.ToBase64String(bytes, Base64FormattingOptions.None);

            // Act
            var result = bytes.ToBase64FromBytes(Base64FormattingOptions.None);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToBase64FromBytes_WithInsertLineBreaksOption_ReturnsExpectedBase64()
        {
            // Arrange
            byte[] bytes = new byte[60];
            for (int i = 0; i < bytes.Length; i++) bytes[i] = (byte)i;
            var expected = Convert.ToBase64String(bytes, Base64FormattingOptions.InsertLineBreaks);

            // Act
            var result = bytes.ToBase64FromBytes(Base64FormattingOptions.InsertLineBreaks);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToBase64FromBytes_NullOrEmpty_ThrowsArgumentNullException()
        {
            // Arrange
            byte[] nullBytes = null;
            byte[] emptyBytes = Array.Empty<byte>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => nullBytes.ToBase64FromBytes(Base64FormattingOptions.None));
            Assert.Throws<ArgumentNullException>(() => emptyBytes.ToBase64FromBytes(Base64FormattingOptions.None));
        }
    }
}
