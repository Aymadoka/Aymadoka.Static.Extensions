namespace Aymadoka.Static.StringExtension
{
    public class String_ConcatTests
    {
        [Fact]
        public void Concat_TwoStrings_ReturnsConcatenatedString()
        {
            string str0 = "Hello";
            string str1 = "World";
            var result = str0.Concat(str1);
            Assert.Equal("HelloWorld", result);
        }

        [Fact]
        public void Concat_ThreeStrings_ReturnsConcatenatedString()
        {
            string str0 = "A";
            string str1 = "B";
            string str2 = "C";
            var result = str0.Concat(str1, str2);
            Assert.Equal("ABC", result);
        }

        [Fact]
        public void Concat_FourStrings_ReturnsConcatenatedString()
        {
            string str0 = "1";
            string str1 = "2";
            string str2 = "3";
            string str3 = "4";
            var result = str0.Concat(str1, str2, str3);
            Assert.Equal("1234", result);
        }

        [Fact]
        public void Concat_WithNullArguments_TreatsNullAsEmpty()
        {
            string str0 = null;
            string str1 = "X";
            string str2 = null;
            string str3 = "Y";

            Assert.Equal("X", str0.Concat(str1));
            Assert.Equal("X", str1.Concat(str2));
            Assert.Equal("XY", str0.Concat(str1, str3));
            Assert.Equal("XY", str0.Concat(str1, str2, str3));
        }
    }
}
