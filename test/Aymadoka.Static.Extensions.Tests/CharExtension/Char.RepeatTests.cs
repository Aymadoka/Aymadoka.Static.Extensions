namespace Aymadoka.Static.CharExtension
{
    public class Char_RepeatTests
    {
        [Theory]
        [InlineData('a', 3, "aaa")]
        [InlineData('b', 1, "b")]
        [InlineData('x', 0, "")]
        public void Repeat_ReturnsExpectedString(char input, int count, string expected)
        {
            var result = input.Repeat(count);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Repeat_NegativeCount_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => 'c'.Repeat(-1));
        }
    }
}
