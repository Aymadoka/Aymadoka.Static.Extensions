namespace Aymadoka.Static.CharExtension
{
    public class Char_ToLowerInvariantTests
    {
        [Theory]
        [InlineData('A', 'a')]
        [InlineData('Z', 'z')]
        [InlineData('a', 'a')]
        [InlineData('z', 'z')]
        [InlineData('1', '1')]
        [InlineData('!', '!')]
        [InlineData('Ç', 'ç')]
        [InlineData('ß', 'ß')] // ß 没有大写
        public void ToLowerInvariant_ReturnsExpectedResult(char input, char expected)
        {
            var result = input.ToLowerInvariant();
            Assert.Equal(expected, result);
        }
    }
}
