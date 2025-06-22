namespace Aymadoka.Static.EnumerableExtension
{
    public class Enumerable_ContainsAnyTests
    {
        [Fact]
        public void ContainsAny_ReturnsTrue_WhenAnyValueExists()
        {
            var source = new List<int> { 1, 2, 3, 4 };
            Assert.True(source.ContainsAny(2, 5));
        }

        [Fact]
        public void ContainsAny_ReturnsFalse_WhenNoValueExists()
        {
            var source = new List<int> { 1, 2, 3, 4 };
            Assert.False(source.ContainsAny(5, 6));
        }

        [Fact]
        public void ContainsAny_ReturnsFalse_WhenValuesIsEmpty()
        {
            var source = new List<int> { 1, 2, 3, 4 };
            Assert.False(source.ContainsAny());
        }

        [Fact]
        public void ContainsAny_ReturnsFalse_WhenSourceIsEmpty()
        {
            var source = new List<int>();
            Assert.False(source.ContainsAny(1, 2));
        }

        [Fact]
        public void ContainsAny_WorksWithReferenceTypes()
        {
            var source = new List<string> { "a", "b", "c" };
            Assert.True(source.ContainsAny("b", "z"));
            Assert.False(source.ContainsAny("x", "y"));
        }
    }
}
