using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aymadoka.Static.StringExtension
{
    public class StringExtensionsTests
    {
        [Fact]
        public void IsNull_ShouldReturnTrue_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.IsNull();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNull_ShouldReturnFalse_WhenStringIsNotNull()
        {
            // Arrange
            string? input = "Hello, World!";

            // Act
            var result = input.IsNull();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNotNull_ShouldReturnFalse_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.IsNotNull();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNotNull_ShouldReturnTrue_WhenStringIsNotNull()
        {
            // Arrange
            string? input = "Hello, World!";

            // Act
            var result = input.IsNotNull();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrEmpty_ShouldReturnTrue_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.IsNullOrEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrEmpty_ShouldReturnTrue_WhenStringIsEmpty()
        {
            // Arrange
            string? input = string.Empty;

            // Act
            var result = input.IsNullOrEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrEmpty_ShouldReturnFalse_WhenStringIsNotEmpty()
        {
            // Arrange
            string? input = "Hello, World!";

            // Act
            var result = input.IsNullOrEmpty();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNotNullOrEmpty_ShouldReturnFalse_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.IsNotNullOrEmpty();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNotNullOrEmpty_ShouldReturnFalse_WhenStringIsEmpty()
        {
            // Arrange
            string? input = string.Empty;

            // Act
            var result = input.IsNotNullOrEmpty();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNotNullOrEmpty_ShouldReturnTrue_WhenStringIsNotEmpty()
        {
            // Arrange
            string? input = "Hello, World!";

            // Act
            var result = input.IsNotNullOrEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrWhiteSpace_ShouldReturnTrue_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.IsNullOrWhiteSpace();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrWhiteSpace_ShouldReturnTrue_WhenStringIsEmpty()
        {
            // Arrange
            string? input = string.Empty;

            // Act
            var result = input.IsNullOrWhiteSpace();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrWhiteSpace_ShouldReturnTrue_WhenStringIsWhitespace()
        {
            // Arrange
            string? input = "   ";

            // Act
            var result = input.IsNullOrWhiteSpace();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNullOrWhiteSpace_ShouldReturnFalse_WhenStringIsNotEmptyOrWhitespace()
        {
            // Arrange
            string? input = "Hello, World!";

            // Act
            var result = input.IsNullOrWhiteSpace();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_ShouldReturnFalse_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.IsNotNullOrWhiteSpace();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_ShouldReturnFalse_WhenStringIsEmpty()
        {
            // Arrange
            string? input = string.Empty;

            // Act
            var result = input.IsNotNullOrWhiteSpace();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_ShouldReturnFalse_WhenStringIsWhitespace()
        {
            // Arrange
            string? input = "   ";

            // Act
            var result = input.IsNotNullOrWhiteSpace();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNotNullOrWhiteSpace_ShouldReturnTrue_WhenStringIsNotEmptyOrWhitespace()
        {
            // Arrange
            string? input = "Hello, World!";

            // Act
            var result = input.IsNotNullOrWhiteSpace();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Reverse_ShouldReturnNull_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.Reverse();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Reverse_ShouldReturnEmptyString_WhenStringIsEmpty()
        {
            // Arrange
            string? input = string.Empty;

            // Act
            var result = input.Reverse();

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Reverse_ShouldReturnReversedString_WhenStringIsNotEmpty()
        {
            // Arrange
            string? input = "Hello";

            // Act
            var result = input.Reverse();

            // Assert
            Assert.Equal("olleH", result);
        }

        [Fact]
        public void Reverse_ShouldReturnReversedString_WhenStringContainsWhitespace()
        {
            // Arrange
            string? input = "Hello World";

            // Act
            var result = input.Reverse();

            // Assert
            Assert.Equal("dlroW olleH", result);
        }

        [Fact]
        public void Reverse_ShouldReturnSameString_WhenStringIsWhitespaceOnly()
        {
            // Arrange
            string? input = "   ";

            // Act
            var result = input.Reverse();

            // Assert
            Assert.Equal("   ", result);
        }

        [Fact]
        public void Reverse_ShouldHandleSingleCharacterString()
        {
            // Arrange
            string? input = "A";

            // Act
            var result = input.Reverse();

            // Assert
            Assert.Equal("A", result);
        }

        [Fact]
        public void IsValidEmail_ShouldReturnFalse_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.IsValidEmail();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidEmail_ShouldReturnFalse_WhenStringIsEmpty()
        {
            // Arrange
            string? input = string.Empty;

            // Act
            var result = input.IsValidEmail();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidEmail_ShouldReturnFalse_WhenStringIsWhitespace()
        {
            // Arrange
            string? input = "   ";

            // Act
            var result = input.IsValidEmail();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidEmail_ShouldReturnFalse_WhenStringIsInvalidEmail()
        {
            // Arrange
            string? input = "invalid-email";

            // Act
            var result = input.IsValidEmail();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidEmail_ShouldReturnTrue_WhenStringIsValidEmail()
        {
            // Arrange
            string? input = "test@example.com";

            // Act
            var result = input.IsValidEmail();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidEmail_ShouldReturnTrue_WhenStringIsValidEmailWithSubdomain()
        {
            // Arrange
            string? input = "user@mail.example.com";

            // Act
            var result = input.IsValidEmail();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidEmail_ShouldReturnFalse_WhenStringHasInvalidDomain()
        {
            // Arrange
            string? input = "user@.com";

            // Act
            var result = input.IsValidEmail();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidEmail_ShouldReturnFalse_WhenStringHasInvalidCharacters()
        {
            // Arrange
            string? input = "user@exa mple.com";

            // Act
            var result = input.IsValidEmail();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidPhoneNumber_ShouldReturnFalse_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.IsValidPhoneNumber();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidPhoneNumber_ShouldReturnFalse_WhenStringIsEmpty()
        {
            // Arrange
            string? input = string.Empty;

            // Act
            var result = input.IsValidPhoneNumber();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidPhoneNumber_ShouldReturnFalse_WhenStringIsWhitespace()
        {
            // Arrange
            string? input = "   ";

            // Act
            var result = input.IsValidPhoneNumber();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidPhoneNumber_ShouldReturnTrue_WhenStringIsValidPhoneNumber()
        {
            // Arrange
            string? input = "+1-800-555-1234";

            // Act
            var result = input.IsValidPhoneNumber();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidPhoneNumber_ShouldReturnTrue_WhenStringIsValidPhoneNumberWithoutCountryCode()
        {
            // Arrange
            string? input = "800-555-1234";

            // Act
            var result = input.IsValidPhoneNumber();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidPhoneNumber_ShouldReturnFalse_WhenStringHasInvalidCharacters()
        {
            // Arrange
            string? input = "800-555-12AB";

            // Act
            var result = input.IsValidPhoneNumber();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidPhoneNumber_ShouldReturnFalse_WhenStringIsTooShort()
        {
            // Arrange
            string? input = "123";

            // Act
            var result = input.IsValidPhoneNumber();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidPhoneNumber_ShouldReturnTrue_WhenStringIsValidPhoneNumberWithSpaces()
        {
            // Arrange
            string? input = "+44 20 7946 0958";

            // Act
            var result = input.IsValidPhoneNumber();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidUrl_ShouldReturnFalse_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = StringExtensions.IsValidUrl(input);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidUrl_ShouldReturnFalse_WhenStringIsEmpty()
        {
            // Arrange
            string input = string.Empty;

            // Act
            var result = StringExtensions.IsValidUrl(input);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidUrl_ShouldReturnFalse_WhenStringIsInvalidUrl()
        {
            // Arrange
            string input = "invalid-url";

            // Act
            var result = StringExtensions.IsValidUrl(input);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidUrl_ShouldReturnTrue_WhenStringIsValidHttpUrl()
        {
            // Arrange
            string input = "http://example.com";

            // Act
            var result = StringExtensions.IsValidUrl(input);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidUrl_ShouldReturnTrue_WhenStringIsValidHttpsUrl()
        {
            // Arrange
            string input = "https://example.com";

            // Act
            var result = StringExtensions.IsValidUrl(input);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidUrl_ShouldReturnTrue_WhenStringIsValidUrlWithPort()
        {
            // Arrange
            string input = "http://example.com:8080";

            // Act
            var result = StringExtensions.IsValidUrl(input);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidUrl_ShouldReturnTrue_WhenStringIsValidUrlWithQueryParameters()
        {
            // Arrange
            string input = "http://example.com?param1=value1&param2=value2";

            // Act
            var result = StringExtensions.IsValidUrl(input);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidUrl_ShouldReturnFalse_WhenStringIsMissingScheme()
        {
            // Arrange
            string input = "www.example.com";

            // Act
            var result = StringExtensions.IsValidUrl(input);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ToTitleCase_ShouldReturnNull_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.ToTitleCase();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void ToTitleCase_ShouldReturnEmptyString_WhenStringIsEmpty()
        {
            // Arrange
            string? input = string.Empty;

            // Act
            var result = input.ToTitleCase();

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ToTitleCase_ShouldReturnTitleCasedString_WhenStringIsLowercase()
        {
            // Arrange
            string? input = "hello world";

            // Act
            var result = input.ToTitleCase();

            // Assert
            Assert.Equal("Hello World", result);
        }

        [Fact]
        public void ToTitleCase_ShouldReturnTitleCasedString_WhenStringIsMixedCase()
        {
            // Arrange
            string? input = "hElLo WoRLd";

            // Act
            var result = input.ToTitleCase();

            // Assert
            Assert.Equal("Hello World", result);
        }

        [Fact]
        public void ToTitleCase_ShouldReturnTitleCasedString_WhenStringContainsExtraSpaces()
        {
            // Arrange
            string? input = "   hello   world   ";

            // Act
            var result = input.ToTitleCase();

            // Assert
            Assert.Equal("   Hello   World   ", result);
        }

        [Fact]
        public void ToTitleCase_ShouldReturnTitleCasedString_WhenStringContainsSpecialCharacters()
        {
            // Arrange
            string? input = "hello-world!";

            // Act
            var result = input.ToTitleCase();

            // Assert
            Assert.Equal("Hello-World!", result);
        }

        [Fact]
        public void RemoveWhitespace_ShouldReturnNull_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.RemoveWhitespace();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void RemoveWhitespace_ShouldReturnEmptyString_WhenStringIsEmpty()
        {
            // Arrange
            string? input = string.Empty;

            // Act
            var result = input.RemoveWhitespace();

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void RemoveWhitespace_ShouldReturnStringWithoutWhitespace_WhenStringContainsWhitespace()
        {
            // Arrange
            string? input = "Hello World";

            // Act
            var result = input.RemoveWhitespace();

            // Assert
            Assert.Equal("HelloWorld", result);
        }

        [Fact]
        public void RemoveWhitespace_ShouldReturnStringWithoutWhitespace_WhenStringContainsMultipleWhitespaceCharacters()
        {
            // Arrange
            string? input = "  Hello   World  ";

            // Act
            var result = input.RemoveWhitespace();

            // Assert
            Assert.Equal("HelloWorld", result);
        }

        [Fact]
        public void RemoveWhitespace_ShouldReturnSameString_WhenStringContainsNoWhitespace()
        {
            // Arrange
            string? input = "HelloWorld";

            // Act
            var result = input.RemoveWhitespace();

            // Assert
            Assert.Equal("HelloWorld", result);
        }

        [Fact]
        public void RemoveWhitespace_ShouldHandleStringWithOnlyWhitespace()
        {
            // Arrange
            string? input = "     ";

            // Act
            var result = input.RemoveWhitespace();

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Left_ShouldReturnEmptyString_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.Left(5);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Left_ShouldReturnEmptyString_WhenStringIsEmpty()
        {
            // Arrange
            string? input = string.Empty;

            // Act
            var result = input.Left(5);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Left_ShouldReturnEmptyString_WhenLengthIsZero()
        {
            // Arrange
            string? input = "Hello";

            // Act
            var result = input.Left(0);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Left_ShouldReturnEmptyString_WhenLengthIsNegative()
        {
            // Arrange
            string? input = "Hello";

            // Act
            var result = input.Left(-1);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Left_ShouldReturnSubstring_WhenLengthIsLessThanStringLength()
        {
            // Arrange
            string? input = "Hello";

            // Act
            var result = input.Left(3);

            // Assert
            Assert.Equal("Hel", result);
        }

        [Fact]
        public void Left_ShouldReturnFullString_WhenLengthIsEqualToStringLength()
        {
            // Arrange
            string? input = "Hello";

            // Act
            var result = input.Left(5);

            // Assert
            Assert.Equal("Hello", result);
        }

        [Fact]
        public void Left_ShouldReturnFullString_WhenLengthIsGreaterThanStringLength()
        {
            // Arrange
            string? input = "Hello";

            // Act
            var result = input.Left(10);

            // Assert
            Assert.Equal("Hello", result);
        }

        [Fact]
        public void Right_ShouldReturnEmptyString_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.Right(5);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Right_ShouldReturnEmptyString_WhenStringIsEmpty()
        {
            // Arrange
            string input = string.Empty;

            // Act
            var result = input.Right(5);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Right_ShouldReturnEmptyString_WhenLengthIsZero()
        {
            // Arrange
            string input = "Hello";

            // Act
            var result = input.Right(0);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Right_ShouldReturnEmptyString_WhenLengthIsNegative()
        {
            // Arrange
            string input = "Hello";

            // Act
            var result = input.Right(-1);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Right_ShouldReturnSubstring_WhenLengthIsLessThanStringLength()
        {
            // Arrange
            string input = "Hello";

            // Act
            var result = input.Right(3);

            // Assert
            Assert.Equal("llo", result);
        }

        [Fact]
        public void Right_ShouldReturnFullString_WhenLengthIsEqualToStringLength()
        {
            // Arrange
            string input = "Hello";

            // Act
            var result = input.Right(5);

            // Assert
            Assert.Equal("Hello", result);
        }

        [Fact]
        public void Right_ShouldReturnFullString_WhenLengthIsGreaterThanStringLength()
        {
            // Arrange
            string input = "Hello";

            // Act
            var result = input.Right(10);

            // Assert
            Assert.Equal("Hello", result);
        }

        [Fact]
        public void ToBase64_ShouldReturnNull_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.ToBase64();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void ToBase64_ShouldReturnEmptyString_WhenStringIsEmpty()
        {
            // Arrange
            string input = string.Empty;

            // Act
            var result = input.ToBase64();

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ToBase64_ShouldReturnBase64EncodedString_WhenStringIsValid()
        {
            // Arrange
            string input = "Hello, World!";

            // Act
            var result = input.ToBase64();

            // Assert
            Assert.Equal("SGVsbG8sIFdvcmxkIQ==", result);
        }

        [Fact]
        public void ToBase64_ShouldHandleSpecialCharacters()
        {
            // Arrange
            string input = "特殊字符!@#$%^&*()";

            // Act
            var result = input.ToBase64();

            // Assert
            Assert.Equal("54m55q6K5a2X56ymIUAjJCVeJiooKQ==", result);
        }

        [Fact]
        public void ToBase64_ShouldHandleWhitespaceCorrectly()
        {
            // Arrange
            string input = "   ";

            // Act
            var result = input.ToBase64();

            // Assert
            Assert.Equal("ICAg", result);
        }

        [Fact]
        public void FromBase64_ShouldReturnNull_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.FromBase64();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void FromBase64_ShouldReturnEmptyString_WhenStringIsEmpty()
        {
            // Arrange
            string input = string.Empty;

            // Act
            var result = input.FromBase64();

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void FromBase64_ShouldReturnOriginalString_WhenStringIsValidBase64()
        {
            // Arrange
            string input = "SGVsbG8sIFdvcmxkIQ=="; // Base64 for "Hello, World!"

            // Act
            var result = input.FromBase64();

            // Assert
            Assert.Equal("Hello, World!", result);
        }

        [Fact]
        public void FromBase64_ShouldThrowFormatException_WhenStringIsInvalidBase64()
        {
            // Arrange
            string input = "InvalidBase64";

            // Act & Assert
            Assert.Throws<FormatException>(() => input.FromBase64());
        }

        [Fact]
        public void FromBase64_ShouldHandleSpecialCharacters()
        {
            // Arrange
            string input = "54m55q6K5a2X56ymIUAjJCVeJiooKQ=="; // Base64 for "特殊字符!@#$%^&*()"

            // Act
            var result = input.FromBase64();

            // Assert
            Assert.Equal("特殊字符!@#$%^&*()", result);
        }

        [Fact]
        public void FromBase64_ShouldHandleWhitespaceCorrectly()
        {
            // Arrange
            string input = "ICAg"; // Base64 for "   "

            // Act
            var result = input.FromBase64();

            // Assert
            Assert.Equal("   ", result);
        }

        [Fact]
        public void IsNumeric_ShouldReturnFalse_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.IsNumeric();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNumeric_ShouldReturnFalse_WhenStringIsEmpty()
        {
            // Arrange
            string input = string.Empty;

            // Act
            var result = input.IsNumeric();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNumeric_ShouldReturnFalse_WhenStringIsWhitespace()
        {
            // Arrange
            string input = "   ";

            // Act
            var result = input.IsNumeric();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNumeric_ShouldReturnTrue_WhenStringIsInteger()
        {
            // Arrange
            string input = "123";

            // Act
            var result = input.IsNumeric();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNumeric_ShouldReturnTrue_WhenStringIsDecimal()
        {
            // Arrange
            string input = "123.45";

            // Act
            var result = input.IsNumeric();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNumeric_ShouldReturnTrue_WhenStringIsNegativeNumber()
        {
            // Arrange
            string input = "-123";

            // Act
            var result = input.IsNumeric();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNumeric_ShouldReturnFalse_WhenStringContainsLetters()
        {
            // Arrange
            string input = "123abc";

            // Act
            var result = input.IsNumeric();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNumeric_ShouldReturnFalse_WhenStringContainsSpecialCharacters()
        {
            // Arrange
            string input = "123@#";

            // Act
            var result = input.IsNumeric();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsNumeric_ShouldReturnTrue_WhenStringIsScientificNotation()
        {
            // Arrange
            string input = "1.23e4";

            // Act
            var result = input.IsNumeric();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Capitalize_ShouldReturnNull_WhenStringIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var result = input.Capitalize();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Capitalize_ShouldReturnEmptyString_WhenStringIsEmpty()
        {
            // Arrange
            string input = string.Empty;

            // Act
            var result = input.Capitalize();

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Capitalize_ShouldCapitalizeFirstLetter_WhenStringIsLowercase()
        {
            // Arrange
            string input = "hello";

            // Act
            var result = input.Capitalize();

            // Assert
            Assert.Equal("Hello", result);
        }

        [Fact]
        public void Capitalize_ShouldCapitalizeFirstLetter_WhenStringIsMixedCase()
        {
            // Arrange
            string input = "hELLO";

            // Act
            var result = input.Capitalize();

            // Assert
            Assert.Equal("HELLO", result);
        }

        [Fact]
        public void Capitalize_ShouldReturnSameString_WhenFirstCharacterIsAlreadyUppercase()
        {
            // Arrange
            string input = "Hello";

            // Act
            var result = input.Capitalize();

            // Assert
            Assert.Equal("Hello", result);
        }

        [Fact]
        public void Capitalize_ShouldHandleSingleCharacterString()
        {
            // Arrange
            string input = "a";

            // Act
            var result = input.Capitalize();

            // Assert
            Assert.Equal("A", result);
        }

        [Fact]
        public void Capitalize_ShouldHandleWhitespaceOnlyString()
        {
            // Arrange
            string input = "   ";

            // Act
            var result = input.Capitalize();

            // Assert
            Assert.Equal("   ", result);
        }
    }
}
