using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.CharExtension
{
    public class Char_ToTests
    {
        [Theory]
        [InlineData('a', 'e', new[] { 'a', 'b', 'c', 'd', 'e' })]
        [InlineData('e', 'a', new[] { 'e', 'd', 'c', 'b', 'a' })]
        [InlineData('A', 'D', new[] { 'A', 'B', 'C', 'D' })]
        [InlineData('D', 'A', new[] { 'D', 'C', 'B', 'A' })]
        [InlineData('z', 'z', new[] { 'z' })]
        public void To_ReturnsExpectedSequence(char start, char end, char[] expected)
        {
            // Act
            IEnumerable<char> result = start.To(end);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
