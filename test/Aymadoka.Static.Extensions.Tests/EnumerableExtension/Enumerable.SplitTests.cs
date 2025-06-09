namespace Aymadoka.Static.EnumerableExtension
{
    public class Enumerable_SplitTests
    {
        [Fact]
        public void Split_ThrowsArgumentException_WhenPartsIsZeroOrNegative()
        {
            var data = new[] { 1, 2, 3 };
            Assert.Throws<ArgumentException>(() => data.Split(0).ToList());
            Assert.Throws<ArgumentException>(() => data.Split(-1).ToList());
        }

        [Fact]
        public void Split_ReturnsAllElements_WhenPartsIsOne()
        {
            var data = Enumerable.Range(1, 5);
            var result = data.Split(1).ToList();
            Assert.Single(result);
            Assert.Equal(data, result[0]);
        }

        [Fact]
        public void Split_SplitsEvenly_WhenCountDivisibleByParts()
        {
            var data = Enumerable.Range(1, 6);
            var result = data.Split(3).ToList();
            Assert.Equal(3, result.Count);
            Assert.All(result, part => Assert.Equal(2, part.Count()));
            Assert.Equal(new[] { 1, 2 }, result[0]);
            Assert.Equal(new[] { 3, 4 }, result[1]);
            Assert.Equal(new[] { 5, 6 }, result[2]);
        }

        [Fact]
        public void Split_SplitsWithRemainder_WhenCountNotDivisibleByParts()
        {
            var data = Enumerable.Range(1, 7);
            var result = data.Split(3).ToList();
            Assert.Equal(3, result.Count);
            Assert.Equal(new[] { 1, 2, 3 }, result[0]);
            Assert.Equal(new[] { 4, 5, 6 }, result[1]);
            Assert.Equal(new[] { 7 }, result[2]);
        }

        [Fact]
        public void Split_EmptySource_ReturnsEmpty()
        {
            var data = Enumerable.Empty<int>();
            var result = data.Split(3).ToList();
            Assert.Empty(result);
        }
    }
}
