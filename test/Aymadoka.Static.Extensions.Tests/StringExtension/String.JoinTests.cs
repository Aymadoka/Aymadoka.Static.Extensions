namespace Aymadoka.Static.StringExtension
{
    public class String_JoinTests
    {
        [Fact]
        public void Join_StringArray_ReturnsJoinedString()
        {
            var arr = new[] { "a", "b", "c" };
            var result = ",".Join(arr);
            Assert.Equal("a,b,c", result);
        }

        [Fact]
        public void Join_ObjectArray_ReturnsJoinedString()
        {
            object[] arr = { 1, "b", 3.5 };
            var result = "-".Join(arr);
            Assert.Equal("1-b-3.5", result);
        }

        [Fact]
        public void Join_GenericIEnumerable_ReturnsJoinedString()
        {
            IEnumerable<int> nums = new List<int> { 1, 2, 3 };
            var result = ";".Join(nums);
            Assert.Equal("1;2;3", result);
        }

        [Fact]
        public void Join_IEnumerableString_ReturnsJoinedString()
        {
            IEnumerable<string> strs = new List<string> { "x", "y", "z" };
            var result = "|".Join(strs);
            Assert.Equal("x|y|z", result);
        }

        [Fact]
        public void Join_StringArrayWithRange_ReturnsJoinedString()
        {
            var arr = new[] { "a", "b", "c", "d" };
            var result = ":".Join(arr, 1, 2);
            Assert.Equal("b:c", result);
        }

        [Fact]
        public void Join_EmptyArray_ReturnsEmptyString()
        {
            var arr = new string[0];
            var result = ",".Join(arr);
            Assert.Equal(string.Empty, result);
        }
    }
}
