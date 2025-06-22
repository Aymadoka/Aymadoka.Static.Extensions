using System.Text;

namespace Aymadoka.Static.StringBuilderExtension
{
    public class StringBuilder_SubstringTests
    {
        [Fact]
        public void Substring_StartIndexOnly_ReturnsSubstringToEnd()
        {
            var sb = new StringBuilder("Hello, World!");
            var result = sb.Substring(7);
            Assert.Equal("World!", result);
        }

        [Fact]
        public void Substring_StartIndexAndLength_ReturnsCorrectSubstring()
        {
            var sb = new StringBuilder("Hello, World!");
            var result = sb.Substring(7, 5);
            Assert.Equal("World", result);
        }

        [Fact]
        public void Substring_StartIndexZero_ReturnsWholeString()
        {
            var sb = new StringBuilder("Test");
            var result = sb.Substring(0);
            Assert.Equal("Test", result);
        }

        [Fact]
        public void Substring_EmptyStringBuilder_ReturnsEmptyString()
        {
            var sb = new StringBuilder("");
            var result = sb.Substring(0);
            Assert.Equal("", result);
        }

        [Fact]
        public void Substring_StartIndexAtEnd_ReturnsEmptyString()
        {
            var sb = new StringBuilder("abc");
            var result = sb.Substring(3);
            Assert.Equal("", result);
        }

        [Fact]
        public void Substring_InvalidStartIndex_ThrowsArgumentOutOfRangeException()
        {
            var sb = new StringBuilder("abc");
            Assert.Throws<ArgumentOutOfRangeException>(() => sb.Substring(4));
        }

        [Fact]
        public void Substring_InvalidLength_ThrowsArgumentOutOfRangeException()
        {
            var sb = new StringBuilder("abc");
            Assert.Throws<ArgumentOutOfRangeException>(() => sb.Substring(1, 5));
        }
    }
}
