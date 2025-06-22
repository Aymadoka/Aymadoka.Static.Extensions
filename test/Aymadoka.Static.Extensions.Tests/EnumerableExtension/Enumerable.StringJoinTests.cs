namespace Aymadoka.Static.EnumerableExtension
{
    public class Enumerable_StringJoinTests
    {
        [Fact]
        public void StringJoin_WithStringSeparator_JoinsElementsCorrectly()
        {
            var list = new List<int> { 1, 2, 3 };
            var result = list.StringJoin(", ");
            Assert.Equal("1, 2, 3", result);
        }

        [Fact]
        public void StringJoin_WithCharSeparator_JoinsElementsCorrectly()
        {
            var list = new List<string> { "a", "b", "c" };
            var result = list.StringJoin('-');
            Assert.Equal("a-b-c", result);
        }

        [Fact]
        public void StringJoin_EmptyCollection_ReturnsEmptyString()
        {
            var list = new List<string>();
            var result = list.StringJoin(", ");
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void StringJoin_NullElements_HandlesNullsAsEmptyString()
        {
            var list = new List<string> { "a", null, "c" };
            var result = list.StringJoin(",");
            Assert.Equal("a,,c", result);
        }
    }
}
