namespace Aymadoka.Static.StringExtension
{
    public class String_SplitTests
    {
        [Fact]
        public void Split_WithSeparator_ReturnsExpectedArray()
        {
            var input = "a,b,c";
            var result = input.Split(",", StringSplitOptions.None);
            Assert.Equal(new[] { "a", "b", "c" }, result);
        }

        [Fact]
        public void Split_WithSeparator_RemoveEmptyEntries()
        {
            var input = "a,,b,";
            var result = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            Assert.Equal(new[] { "a", "b" }, result);
        }

        [Fact]
        public void Split_WithNoSeparator_ReturnsWholeString()
        {
            var input = "abc";
            var result = input.Split("|", StringSplitOptions.None);
            Assert.Equal(new[] { "abc" }, result);
        }

        [Fact]
        public void Split_EmptyString_ReturnsArrayWithEmptyString()
        {
            var input = "";
            var result = input.Split(",", StringSplitOptions.None);
            Assert.Equal(new[] { "" }, result);
        }

        [Fact]
        public void Split_SeparatorNotFound_ReturnsOriginalString()
        {
            var input = "abc";
            var result = input.Split(";", StringSplitOptions.None);
            Assert.Equal(new[] { "abc" }, result);
        }
    }
}
