using Aymadoka.Static.HashExtension;
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
            string result = input.ToMd5Hash();

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
            string result = input.ToMd5Hash();

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithNullString_ThrowsArgumentNullException()
        {
            // Arrange
            string? input = null;

            // Act
            var exception = Record.Exception(() => input.ToMd5Hash());

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
            string result = input.ToMd5Hash(salt);

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
            string result = input.ToMd5Hash(salt);

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
            string result = input.ToMd5Hash(salt);

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
            string result = input.ToMd5Hash(salt);

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
            var exception = Record.Exception(() => input.ToMd5Hash(salt));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ArgumentNullException>();
        }

        [Theory]
        [InlineData("test", EnumHashFormat.x2, "098f6bcd4621d373cade4e832627b4f6")] // Lowercase, 32 characters
        [InlineData("test", EnumHashFormat.x, "98f6bcd4621d373cade4e832627b4f6")]  // Lowercase, 31 characters
        [InlineData("test", EnumHashFormat.X2, "098F6BCD4621D373CADE4E832627B4F6")] // Uppercase, 32 characters
        [InlineData("test", EnumHashFormat.X, "98F6BCD4621D373CADE4E832627B4F6")]  // Uppercase, 31 characters
        public void ToMd5_WithValidStringAndFormat_ReturnsCorrectHash(string input, EnumHashFormat format, string expectedHash)
        {
            // Act
            var result = input.ToMd5Hash(format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithEmptyStringAndFormat_ReturnsCorrectHash()
        {
            // Arrange
            var input = string.Empty;
            var format = EnumHashFormat.x2;
            var expectedHash = "d41d8cd98f00b204e9800998ecf8427e"; // MD5("")

            // Act
            var result = input.ToMd5Hash(format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithNullString_ThrowsArgumentNullException2()
        {
            // Arrange
            string? input = null;
            var format = EnumHashFormat.x2;

            // Act
            var exception = Record.Exception(() => input.ToMd5Hash(format));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ArgumentNullException>();
        }

        [Theory]
        [InlineData("test", "salt", EnumHashFormat.x2, "d653ea7ea31e77b41041e7e3d32e3e4a")] // Lowercase, 32 characters
        [InlineData("test", "salt", EnumHashFormat.x, "d653ea7ea31e77b41041e7e3d32e3e4a")]  // Lowercase, 32 characters
        [InlineData("test", "salt", EnumHashFormat.X2, "D653EA7EA31E77B41041E7E3D32E3E4A")] // Uppercase, 32 characters
        [InlineData("test", "salt", EnumHashFormat.X, "D653EA7EA31E77B41041E7E3D32E3E4A")]  // Uppercase, 32 characters
        public void ToMd5_WithValidStringSaltAndFormat_ReturnsCorrectHash(string input, string salt, EnumHashFormat format, string expectedHash)
        {
            // Act
            string result = input.ToMd5Hash(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithEmptyStringAndSalt_ReturnsCorrectHash3()
        {
            // Arrange
            string input = string.Empty;
            string salt = "salt";
            EnumHashFormat format = EnumHashFormat.x2;
            string expectedHash = "ceb20772e0c9d240c75eb26b0e37abee"; // MD5("salt")

            // Act
            string result = input.ToMd5Hash(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithValidStringAndEmptySalt_ReturnsCorrectHash3()
        {
            // Arrange
            string input = "test";
            string salt = string.Empty;
            EnumHashFormat format = EnumHashFormat.x2;
            string expectedHash = "098f6bcd4621d373cade4e832627b4f6"; // MD5("test")

            // Act
            string result = input.ToMd5Hash(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithValidStringAndNullSalt_ReturnsCorrectHash3()
        {
            // Arrange
            string input = "test";
            string? salt = null;
            EnumHashFormat format = EnumHashFormat.x2;
            string expectedHash = "098f6bcd4621d373cade4e832627b4f6"; // MD5("test")

            // Act
            string result = input.ToMd5Hash(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithNullString_ThrowsArgumentNullException3()
        {
            // Arrange
            string? input = null;
            string salt = "salt";
            EnumHashFormat format = EnumHashFormat.x2;

            // Act
            var exception = Record.Exception(() => input.ToMd5Hash(salt, format));

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
            string result = input.ToMd5Hash();

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
            string result = input.ToMd5Hash();

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithNullByteArray_ThrowsArgumentNullException5()
        {
            // Arrange
            byte[]? input = null;

            // Act
            var exception = Record.Exception(() => input.ToMd5Hash());

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
            string result = input.ToMd5Hash(salt);

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
            string result = input.ToMd5Hash(salt);

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
            string result = input.ToMd5Hash(salt);

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
            string result = input.ToMd5Hash(salt);

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
            var exception = Record.Exception(() => input.ToMd5Hash(salt));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ArgumentNullException>();
        }

        [Theory]
        [InlineData("test", EnumHashFormat.x2, "098f6bcd4621d373cade4e832627b4f6")] // Lowercase, 32 characters
        [InlineData("test", EnumHashFormat.x, "98f6bcd4621d373cade4e832627b4f6")]  // Lowercase, 31 characters
        [InlineData("test", EnumHashFormat.X2, "098F6BCD4621D373CADE4E832627B4F6")] // Uppercase, 32 characters
        [InlineData("test", EnumHashFormat.X, "98F6BCD4621D373CADE4E832627B4F6")]  // Uppercase, 31 characters
        public void ToMd5_WithValidByteArrayAndFormat_ReturnsCorrectHash(string input, EnumHashFormat format, string expectedHash)
        {
            // Arrange
            byte[] byteArray = Encoding.UTF8.GetBytes(input);

            // Act
            string result = byteArray.ToMd5Hash(format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithEmptyByteArrayAndFormat_ReturnsCorrectHash()
        {
            // Arrange
            byte[] byteArray = [];
            EnumHashFormat format = EnumHashFormat.x2;
            string expectedHash = "d41d8cd98f00b204e9800998ecf8427e"; // MD5("")

            // Act
            string result = byteArray.ToMd5Hash(format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithNullByteArray_ThrowsArgumentNullException()
        {
            // Arrange
            byte[]? byteArray = null;
            EnumHashFormat format = EnumHashFormat.x2;

            // Act
            var exception = Record.Exception(() => byteArray.ToMd5Hash(format));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ArgumentNullException>();
        }

        [Theory]
        [InlineData("test", "salt", EnumHashFormat.x2, "d653ea7ea31e77b41041e7e3d32e3e4a")] // Lowercase, 32 characters
        [InlineData("test", "salt", EnumHashFormat.x, "d653ea7ea31e77b41041e7e3d32e3e4a")]  // Lowercase, 32 characters
        [InlineData("test", "salt", EnumHashFormat.X2, "D653EA7EA31E77B41041E7E3D32E3E4A")] // Uppercase, 32 characters
        [InlineData("test", "salt", EnumHashFormat.X, "D653EA7EA31E77B41041E7E3D32E3E4A")]  // Uppercase, 32 characters
        public void ToMd5_WithValidByteArraySaltAndFormat_ReturnsCorrectHash8(string input, string salt, EnumHashFormat format, string expectedHash)
        {
            // Arrange
            byte[] byteArray = Encoding.UTF8.GetBytes(input);

            // Act
            string result = byteArray.ToMd5Hash(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithEmptyByteArrayAndSalt_ReturnsCorrectHash8()
        {
            // Arrange
            byte[] byteArray = [];
            string salt = "salt";
            EnumHashFormat format = EnumHashFormat.x2;
            string expectedHash = "ceb20772e0c9d240c75eb26b0e37abee"; // MD5("salt")

            // Act
            string result = byteArray.ToMd5Hash(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithValidByteArrayAndEmptySalt_ReturnsCorrectHash8()
        {
            // Arrange
            byte[] byteArray = Encoding.UTF8.GetBytes("test");
            string salt = string.Empty;
            EnumHashFormat format = EnumHashFormat.x2;
            string expectedHash = "098f6bcd4621d373cade4e832627b4f6"; // MD5("test")

            // Act
            string result = byteArray.ToMd5Hash(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithValidByteArrayAndNullSalt_ReturnsCorrectHash8()
        {
            // Arrange
            byte[] byteArray = Encoding.UTF8.GetBytes("test");
            string? salt = null;
            EnumHashFormat format = EnumHashFormat.x2;
            string expectedHash = "098f6bcd4621d373cade4e832627b4f6"; // MD5("test")

            // Act
            string result = byteArray.ToMd5Hash(salt, format);

            // Assert
            Assert.Equal(expectedHash, result);
        }

        [Fact]
        public void ToMd5_WithNullByteArrayAndValidSalt_ThrowsArgumentNullException8()
        {
            // Arrange
            byte[]? byteArray = null;
            string salt = "salt";
            EnumHashFormat format = EnumHashFormat.x2;

            // Act
            var exception = Record.Exception(() => byteArray.ToMd5Hash(salt, format));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ArgumentNullException>();
        }
    }
}
