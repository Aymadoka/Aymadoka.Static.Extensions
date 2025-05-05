using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aymadoka.Static.Base64Extension
{
    public class Base64ExtensionsTests
    {
        [Fact] 
        public void ToBase64_ValidByteArray_ReturnsBase64String()
        {
            // Arrange
            var bytes = Encoding.UTF8.GetBytes("Hello, World!");

            // Act
            var result = bytes.ToBase64String();

            // Assert
            Assert.Equal(Convert.ToBase64String(bytes), result);
        }

        [Fact]
        public void ToBase64_NullOrEmptyByteArray_ThrowsArgumentNullException()
        {
            // Arrange
            byte[]? bytes = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => bytes.ToBase64String());
        }

        [Fact]
        public void ToBase64FromString_ValidString_ReturnsBase64String()
        {
            // Arrange
            var input = "Hello, World!";

            // Act
            var result = input.ToBase64FromString();

            // Assert
            Assert.Equal(Convert.ToBase64String(Encoding.UTF8.GetBytes(input)), result);
        }

        [Fact]
        public void ToBase64FromString_NullOrEmptyString_ThrowsArgumentNullException()
        {
            // Arrange
            string? input = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => input.ToBase64FromString());
        }

        [Fact]
        public void FromBase64_ValidBase64String_ReturnsByteArray()
        {
            // Arrange
            var base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes("Hello, World!"));

            // Act
            var result = base64.FromBase64();

            // Assert
            Assert.Equal(Encoding.UTF8.GetBytes("Hello, World!"), result);
        }

        [Fact]
        public void FromBase64_InvalidBase64String_ThrowsFormatException()
        {
            // Arrange
            var invalidBase64 = "InvalidBase64===";

            // Act & Assert
            Assert.Throws<FormatException>(() => invalidBase64.FromBase64());
        }

        [Fact]
        public void FromBase64_NullOrEmptyString_ThrowsArgumentNullException()
        {
            // Arrange
            string? base64 = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => base64.FromBase64());
        }

        [Fact]
        public void FromBase64ToString_ValidBase64String_ReturnsOriginalString()
        {
            // Arrange
            var original = "Hello, World!";
            var base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(original));

            // Act
            var result = base64.FromBase64ToString();

            // Assert
            Assert.Equal(original, result);
        }

        [Fact]
        public void FromBase64ToString_InvalidBase64String_ThrowsFormatException()
        {
            // Arrange
            var invalidBase64 = "InvalidBase64===";

            // Act & Assert
            Assert.Throws<FormatException>(() => invalidBase64.FromBase64ToString());
        }

        [Fact]
        public void FromBase64ToString_NullOrEmptyString_ThrowsArgumentNullException()
        {
            // Arrange
            string? base64 = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => base64.FromBase64ToString());
        }
    }
}
