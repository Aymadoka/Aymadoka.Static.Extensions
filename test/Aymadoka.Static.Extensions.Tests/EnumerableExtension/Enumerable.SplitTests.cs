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
