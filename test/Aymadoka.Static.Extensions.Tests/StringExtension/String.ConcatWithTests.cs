namespace Aymadoka.Static.StringExtension
{
    public class String_ConcatWithTests
    {
        [Fact]
        public void ConcatWith_ConcatenatesWithMultipleStrings()
        {
            string baseStr = "Hello";
            string result = baseStr.ConcatWith(", ", "World", "!");
            Assert.Equal("Hello, World!", result);
        }

        [Fact]
        public void ConcatWith_EmptyValues_ReturnsOriginalString()
        {
            string baseStr = "Test";
            string result = baseStr.ConcatWith();
            Assert.Equal("Test", result);
        }

        [Fact]
        public void ConcatWith_NullValues_TreatedAsEmpty()
        {
            string baseStr = "A";
            string result = baseStr.ConcatWith(null, "B", null);
            Assert.Equal("AB", result);
        }

        [Fact]
        public void ConcatWith_NullBaseString_TreatedAsEmpty()
        {
            string baseStr = null;
            string result = baseStr.ConcatWith("A", "B");
            Assert.Equal("AB", result);
        }

        [Fact]
        public void ConcatWith_AllNulls_ReturnsEmptyString()
        {
            string baseStr = null;
            string result = baseStr.ConcatWith(null, null);
            Assert.Equal(string.Empty, result);
        }
    }
}
