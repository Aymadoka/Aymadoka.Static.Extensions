using Shouldly;
using System.Text;

namespace Aymadoka.Static.Md5Extension
{
    public class Md5ExtensionsTests
    {
        [Fact]
        public void ToMd5_WithValidString_ReturnsCorrectHash()
        {
            // Arrange
            string input = "test";
            string expectedHash = "098f6bcd4621d373cade4e832627b4f6"; // MD5("test") in lowercase x2 format

            // Act
            string result = input.ToMd5();

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithEmptyString_ReturnsCorrectHash()
        {
            // Arrange
            string input = string.Empty;
            string expectedHash = "d41d8cd98f00b204e9800998ecf8427e"; // MD5("") in lowercase x2 format

            // Act
            string result = input.ToMd5();

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithNullString_ThrowsArgumentNullException()
        {
            // Arrange
            string? input = null;

            // Act
            var exception = Record.Exception(() => input.ToMd5());

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ArgumentNullException>();
        }

        [Fact]
        public void ToMd5_WithValidStringAndSalt_ReturnsCorrectHash()
        {
            // Arrange
            string input = "test";
            string salt = "salt";
            string expectedHash = "d653ea7ea31e77b41041e7e3d32e3e4a"; // Precomputed MD5("salt" + "test")

            // Act
            string result = input.ToMd5(salt);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithEmptyStringAndSalt_ReturnsCorrectHash()
        {
            // Arrange
            string input = string.Empty;
            string salt = "salt";
            string expectedHash = "ceb20772e0c9d240c75eb26b0e37abee"; // Precomputed MD5("salt")

            // Act
            string result = input.ToMd5(salt);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithValidStringAndEmptySalt_ReturnsCorrectHash()
        {
            // Arrange
            string input = "test";
            string salt = string.Empty;
            string expectedHash = "098f6bcd4621d373cade4e832627b4f6"; // Precomputed MD5("test")

            // Act
            string result = input.ToMd5(salt);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithValidStringAndNullSalt_ReturnsCorrectHash()
        {
            // Arrange
            string input = "test";
            string? salt = null;
            string expectedHash = "098f6bcd4621d373cade4e832627b4f6"; // Precomputed MD5("test")

            // Act
            string result = input.ToMd5(salt);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithNullStringAndValidSalt_ThrowsArgumentNullException()
        {
            // Arrange
            string? input = null;
            string salt = "salt";

            // Act
            var exception = Record.Exception(() => input.ToMd5(salt));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ArgumentNullException>();
        }

        [Theory]
        [InlineData("test", EnumMd5Format.x2, "098f6bcd4621d373cade4e832627b4f6")] // Lowercase, 32 characters
        [InlineData("test", EnumMd5Format.x, "98f6bcd4621d373cade4e832627b4f6")]  // Lowercase, 31 characters
        [InlineData("test", EnumMd5Format.X2, "098F6BCD4621D373CADE4E832627B4F6")] // Uppercase, 32 characters
        [InlineData("test", EnumMd5Format.X, "98F6BCD4621D373CADE4E832627B4F6")]  // Uppercase, 31 characters
        public void ToMd5_WithValidStringAndFormat_ReturnsCorrectHash(string input, EnumMd5Format format, string expectedHash)
        {
            // Act
            var result = input.ToMd5(format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithEmptyStringAndFormat_ReturnsCorrectHash()
        {
            // Arrange
            var input = string.Empty;
            var format = EnumMd5Format.x2;
            var expectedHash = "d41d8cd98f00b204e9800998ecf8427e"; // MD5("")

            // Act
            var result = input.ToMd5(format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithNullString_ThrowsArgumentNullException2()
        {
            // Arrange
            string? input = null;
            var format = EnumMd5Format.x2;

            // Act
            var exception = Record.Exception(() => input.ToMd5(format));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ArgumentNullException>();
        }

        [Theory]
        [InlineData("test", "salt", EnumMd5Format.x2, "d653ea7ea31e77b41041e7e3d32e3e4a")] // Lowercase, 32 characters
        [InlineData("test", "salt", EnumMd5Format.x, "d653ea7ea31e77b41041e7e3d32e3e4a")]  // Lowercase, 32 characters
        [InlineData("test", "salt", EnumMd5Format.X2, "D653EA7EA31E77B41041E7E3D32E3E4A")] // Uppercase, 32 characters
        [InlineData("test", "salt", EnumMd5Format.X, "D653EA7EA31E77B41041E7E3D32E3E4A")]  // Uppercase, 32 characters
        public void ToMd5_WithValidStringSaltAndFormat_ReturnsCorrectHash(string input, string salt, EnumMd5Format format, string expectedHash)
        {
            // Act
            string result = input.ToMd5(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithEmptyStringAndSalt_ReturnsCorrectHash3()
        {
            // Arrange
            string input = string.Empty;
            string salt = "salt";
            EnumMd5Format format = EnumMd5Format.x2;
            string expectedHash = "ceb20772e0c9d240c75eb26b0e37abee"; // MD5("salt")

            // Act
            string result = input.ToMd5(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithValidStringAndEmptySalt_ReturnsCorrectHash3()
        {
            // Arrange
            string input = "test";
            string salt = string.Empty;
            EnumMd5Format format = EnumMd5Format.x2;
            string expectedHash = "098f6bcd4621d373cade4e832627b4f6"; // MD5("test")

            // Act
            string result = input.ToMd5(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithValidStringAndNullSalt_ReturnsCorrectHash3()
        {
            // Arrange
            string input = "test";
            string? salt = null;
            EnumMd5Format format = EnumMd5Format.x2;
            string expectedHash = "098f6bcd4621d373cade4e832627b4f6"; // MD5("test")

            // Act
            string result = input.ToMd5(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithNullString_ThrowsArgumentNullException3()
        {
            // Arrange
            string? input = null;
            string salt = "salt";
            EnumMd5Format format = EnumMd5Format.x2;

            // Act
            var exception = Record.Exception(() => input.ToMd5(salt, format));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ArgumentNullException>();
        }

        [Fact]
        public void ToMd5_WithValidByteArray_ReturnsCorrectHash5()
        {
            // Arrange
            byte[] input = Encoding.UTF8.GetBytes("test");
            string expectedHash = "098f6bcd4621d373cade4e832627b4f6"; // MD5("test") in lowercase x2 format

            // Act
            string result = input.ToMd5();

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithEmptyByteArray_ReturnsCorrectHash5()
        {
            // Arrange
            byte[] input = [];
            string expectedHash = "d41d8cd98f00b204e9800998ecf8427e"; // MD5("") in lowercase x2 format

            // Act
            string result = input.ToMd5();

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithNullByteArray_ThrowsArgumentNullException5()
        {
            // Arrange
            byte[]? input = null;

            // Act
            var exception = Record.Exception(() => input.ToMd5());

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ArgumentNullException>();
        }

        [Fact]
        public void ToMd5_WithValidByteArrayAndSalt_ReturnsCorrectHash()
        {
            // Arrange
            byte[] input = Encoding.UTF8.GetBytes("test");
            string salt = "salt";
            string expectedHash = "d653ea7ea31e77b41041e7e3d32e3e4a"; // Precomputed MD5("salt" + "test")

            // Act
            string result = input.ToMd5(salt);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithEmptyByteArrayAndSalt_ReturnsCorrectHash()
        {
            // Arrange
            byte[] input = [];
            string salt = "salt";
            string expectedHash = "ceb20772e0c9d240c75eb26b0e37abee"; // Precomputed MD5("salt")

            // Act
            string result = input.ToMd5(salt);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithValidByteArrayAndEmptySalt_ReturnsCorrectHash()
        {
            // Arrange
            byte[] input = Encoding.UTF8.GetBytes("test");
            string salt = string.Empty;
            string expectedHash = "098f6bcd4621d373cade4e832627b4f6"; // Precomputed MD5("test")

            // Act
            string result = input.ToMd5(salt);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithValidByteArrayAndNullSalt_ReturnsCorrectHash()
        {
            // Arrange
            byte[] input = Encoding.UTF8.GetBytes("test");
            string? salt = null;
            string expectedHash = "098f6bcd4621d373cade4e832627b4f6"; // Precomputed MD5("test")

            // Act
            string result = input.ToMd5(salt);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithNullByteArrayAndValidSalt_ThrowsArgumentNullException()
        {
            // Arrange
            byte[]? input = null;
            string salt = "salt";

            // Act
            var exception = Record.Exception(() => input.ToMd5(salt));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ArgumentNullException>();
        }

        [Theory]
        [InlineData("test", EnumMd5Format.x2, "098f6bcd4621d373cade4e832627b4f6")] // Lowercase, 32 characters
        [InlineData("test", EnumMd5Format.x, "98f6bcd4621d373cade4e832627b4f6")]  // Lowercase, 31 characters
        [InlineData("test", EnumMd5Format.X2, "098F6BCD4621D373CADE4E832627B4F6")] // Uppercase, 32 characters
        [InlineData("test", EnumMd5Format.X, "98F6BCD4621D373CADE4E832627B4F6")]  // Uppercase, 31 characters
        public void ToMd5_WithValidByteArrayAndFormat_ReturnsCorrectHash(string input, EnumMd5Format format, string expectedHash)
        {
            // Arrange
            byte[] byteArray = Encoding.UTF8.GetBytes(input);

            // Act
            string result = byteArray.ToMd5(format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithEmptyByteArrayAndFormat_ReturnsCorrectHash()
        {
            // Arrange
            byte[] byteArray = [];
            EnumMd5Format format = EnumMd5Format.x2;
            string expectedHash = "d41d8cd98f00b204e9800998ecf8427e"; // MD5("")

            // Act
            string result = byteArray.ToMd5(format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithNullByteArray_ThrowsArgumentNullException()
        {
            // Arrange
            byte[]? byteArray = null;
            EnumMd5Format format = EnumMd5Format.x2;

            // Act
            var exception = Record.Exception(() => byteArray.ToMd5(format));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ArgumentNullException>();
        }

        [Theory]
        [InlineData("test", "salt", EnumMd5Format.x2, "d653ea7ea31e77b41041e7e3d32e3e4a")] // Lowercase, 32 characters
        [InlineData("test", "salt", EnumMd5Format.x, "d653ea7ea31e77b41041e7e3d32e3e4a")]  // Lowercase, 32 characters
        [InlineData("test", "salt", EnumMd5Format.X2, "D653EA7EA31E77B41041E7E3D32E3E4A")] // Uppercase, 32 characters
        [InlineData("test", "salt", EnumMd5Format.X, "D653EA7EA31E77B41041E7E3D32E3E4A")]  // Uppercase, 32 characters
        public void ToMd5_WithValidByteArraySaltAndFormat_ReturnsCorrectHash8(string input, string salt, EnumMd5Format format, string expectedHash)
        {
            // Arrange
            byte[] byteArray = Encoding.UTF8.GetBytes(input);

            // Act
            string result = byteArray.ToMd5(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithEmptyByteArrayAndSalt_ReturnsCorrectHash8()
        {
            // Arrange
            byte[] byteArray = [];
            string salt = "salt";
            EnumMd5Format format = EnumMd5Format.x2;
            string expectedHash = "ceb20772e0c9d240c75eb26b0e37abee"; // MD5("salt")

            // Act
            string result = byteArray.ToMd5(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithValidByteArrayAndEmptySalt_ReturnsCorrectHash8()
        {
            // Arrange
            byte[] byteArray = Encoding.UTF8.GetBytes("test");
            string salt = string.Empty;
            EnumMd5Format format = EnumMd5Format.x2;
            string expectedHash = "098f6bcd4621d373cade4e832627b4f6"; // MD5("test")

            // Act
            string result = byteArray.ToMd5(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithValidByteArrayAndNullSalt_ReturnsCorrectHash8()
        {
            // Arrange
            byte[] byteArray = Encoding.UTF8.GetBytes("test");
            string? salt = null;
            EnumMd5Format format = EnumMd5Format.x2;
            string expectedHash = "098f6bcd4621d373cade4e832627b4f6"; // MD5("test")

            // Act
            string result = byteArray.ToMd5(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithNullByteArrayAndValidSalt_ThrowsArgumentNullException8()
        {
            // Arrange
            byte[]? byteArray = null;
            string salt = "salt";
            EnumMd5Format format = EnumMd5Format.x2;

            // Act
            var exception = Record.Exception(() => byteArray.ToMd5(salt, format));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ArgumentNullException>();
        }
    }
}
