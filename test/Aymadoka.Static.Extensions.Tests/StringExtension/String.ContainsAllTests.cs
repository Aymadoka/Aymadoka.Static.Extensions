namespace Aymadoka.Static.StringExtension
{
    public class String_ContainsAllTests
    {
        [Fact]
        public void ContainsAll_AllSubstringsPresent_ReturnsTrue()
        {
            string source = "Hello, world! Welcome to C#.";
            Assert.True(source.ContainsAll("Hello", "world", "C#"));
        }

        [Fact]
        public void ContainsAll_SubstringMissing_ReturnsFalse()
        {
            string source = "Hello, world!";
            Assert.False(source.ContainsAll("Hello", "C#", "world"));
        }

        [Fact]
        public void ContainsAll_EmptyValues_ReturnsTrue()
        {
            string source = "abc";
            Assert.True(source.ContainsAll());
        }

        [Fact]
        public void ContainsAll_NullOrEmptySource_ReturnsFalse()
        {
            string source = null;
            Assert.Throws<NullReferenceException>(() => source.ContainsAll("a"));

            string empty = "";
            Assert.False(empty.ContainsAll("a"));
        }

        [Fact]
        public void ContainsAll_WithComparison_AllSubstringsPresent_ReturnsTrue()
        {
            string source = "Hello, World!";
            Assert.True(source.ContainsAll(StringComparison.OrdinalIgnoreCase, "hello", "WORLD"));
        }

        [Fact]
        public void ContainsAll_WithComparison_SubstringMissing_ReturnsFalse()
        {
            string source = "Hello, World!";
            Assert.False(source.ContainsAll(StringComparison.OrdinalIgnoreCase, "hello", "C#"));
        }

        [Fact]
        public void ContainsAll_WithComparison_EmptyValues_ReturnsTrue()
        {
            string source = "abc";
            Assert.True(source.ContainsAll(StringComparison.OrdinalIgnoreCase));
        }

        [Fact]
        public void ContainsAll_WithComparison_NullOrEmptySource_ReturnsFalse()
        {
            string source = null;
            Assert.Throws<NullReferenceException>(() => source.ContainsAll(StringComparison.OrdinalIgnoreCase, "a"));

            string empty = "";
            Assert.False(empty.ContainsAll(StringComparison.OrdinalIgnoreCase, "a"));
        }
    }
}
