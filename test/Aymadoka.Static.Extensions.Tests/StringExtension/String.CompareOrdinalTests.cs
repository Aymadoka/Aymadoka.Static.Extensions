namespace Aymadoka.Static.StringExtension
{
    public class String_CompareOrdinalTests
    {
        [Theory]
        [InlineData("abc", "abc", 0)]
        [InlineData("abc", "abd", -1)]
        [InlineData("abd", "abc", 1)]
        [InlineData("abc", "ABC", 1)]
        [InlineData("ABC", "abc", -1)]
        [InlineData(null, null, 0)]
        [InlineData(null, "abc", -1)]
        [InlineData("abc", null, 1)]
        public void CompareOrdinal_String_ReturnsExpected(string strA, string strB, int expectedSign)
        {
            int result = strA.CompareOrdinal(strB);
            Assert.Equal(expectedSign, result == 0 ? 0 : (result > 0 ? 1 : -1));
        }

        [Theory]
        [InlineData("abcdef", 1, "abczef", 1, 3, -1)] // "bcd" vs "bcz"
        [InlineData("abcdef", 1, "abczef", 1, 2, 0)] // "bc" vs "bc"
        [InlineData("abcdef", 1, "abczef", 1, 4, -1)] // "bcde" vs "bcze"
        [InlineData("abcdef", 2, "abcdef", 2, 2, 0)] // "cd" vs "cd"
        [InlineData("abcdef", 2, "abcdef", 3, 2, -1)] // "cd" vs "de"
        [InlineData("abcdef", 3, "abcdef", 2, 2, 1)] // "de" vs "cd"
        [InlineData(null, 0, null, 0, 0, 0)]
        [InlineData(null, 0, "abc", 0, 1, -1)]
        [InlineData("abc", 0, null, 0, 1, 1)]
        public void CompareOrdinal_Substring_ReturnsExpected(string strA, int indexA, string strB, int indexB, int length, int expectedSign)
        {
            int result = strA.CompareOrdinal(indexA, strB, indexB, length);

            var act = result == 0 ? 0 : (result > 0 ? 1 : -1);
            
            Assert.Equal(expectedSign, act);
        }
    }
}
