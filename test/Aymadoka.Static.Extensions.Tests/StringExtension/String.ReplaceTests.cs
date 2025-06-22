namespace Aymadoka.Static.StringExtension
{
    public class String_ReplaceTests
    {
        [Fact]
        public void Replace_ReplacesSubstringAtStart()
        {
            var original = "abcdef";
            var result = original.Replace(0, 3, "xyz");
            Assert.Equal("xyzdef", result);
        }

        [Fact]
        public void Replace_ReplacesSubstringInMiddle()
        {
            var original = "abcdef";
            var result = original.Replace(2, 2, "XY");
            Assert.Equal("abXYef", result);
        }

        [Fact]
        public void Replace_ReplacesSubstringAtEnd()
        {
            var original = "abcdef";
            var result = original.Replace(4, 2, "ZZ");
            Assert.Equal("abcdZZ", result);
        }

        [Fact]
        public void Replace_WithEmptyValue_RemovesSubstring()
        {
            var original = "abcdef";
            var result = original.Replace(1, 3, "");
            Assert.Equal("aef", result);
        }

        [Fact]
        public void Replace_WithLengthZero_InsertsValue()
        {
            var original = "abcdef";
            var result = original.Replace(3, 0, "123");
            Assert.Equal("abc123def", result);
        }

        [Fact]
        public void Replace_ThrowsArgumentOutOfRangeException_WhenStartIndexInvalid()
        {
            var original = "abc";
            Assert.Throws<System.ArgumentOutOfRangeException>(() => original.Replace(-1, 1, "x"));
            Assert.Throws<System.ArgumentOutOfRangeException>(() => original.Replace(4, 1, "x"));
        }

        [Fact]
        public void Replace_ThrowsArgumentOutOfRangeException_WhenLengthInvalid()
        {
            var original = "abc";
            Assert.Throws<System.ArgumentOutOfRangeException>(() => original.Replace(1, 5, "x"));
            Assert.Throws<System.ArgumentOutOfRangeException>(() => original.Replace(1, -1, "x"));
        }
    }
}
