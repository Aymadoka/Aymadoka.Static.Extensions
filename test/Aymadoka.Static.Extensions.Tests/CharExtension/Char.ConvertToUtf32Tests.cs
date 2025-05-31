using Shouldly;

namespace Aymadoka.Static.CharExtension
{
    public class Char_ConvertToUtf32Tests
    {
        [Fact]
        public void ConvertToUtf32_ValidSurrogatePair_ReturnsExpectedCodePoint()
        {
            // 😀 (U+1F600)
            char high = '\uD83D';
            char low = '\uDE00';
            int expected = 0x1F600;

            int actual = high.ConvertToUtf32(low);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConvertToUtf32_InvalidSurrogatePair_ThrowsArgumentException()
        {
            char high = 'A';
            char low = 'B';

            // Act
            var exception = Record.Exception(() => high.ConvertToUtf32(low));

            // Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<ArgumentOutOfRangeException>();
            exception.ShouldBeAssignableTo<ArgumentException>();
        }
    }
}
