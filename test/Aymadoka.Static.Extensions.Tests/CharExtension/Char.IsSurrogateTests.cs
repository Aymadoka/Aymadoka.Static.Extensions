namespace Aymadoka.Static.CharExtension
{
    public class Char_IsSurrogateTests
    {
        [Theory]
        [InlineData('\uD800', true)] // High surrogate
        [InlineData('\uDBFF', true)] // High surrogate
        [InlineData('\uDC00', true)] // Low surrogate
        [InlineData('\uDFFF', true)] // Low surrogate
        [InlineData('A', false)]     // Regular character
        [InlineData('\uFFFF', false)]// Non-surrogate, non-character
        [InlineData('\u0000', false)]// Null char
        public void IsSurrogate_ReturnsExpected(char input, bool expected)
        {
            bool result = input.IsSurrogate();
            Assert.Equal(expected, result);
        }
    }
}
