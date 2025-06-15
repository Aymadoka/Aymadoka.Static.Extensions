namespace Aymadoka.Static.QueryableExtension
{
    public class Queryable_PageByTests
    {
        [Fact]
        public void PageBy_Should_Throw_ArgumentNullException_When_Query_Is_Null()
        {
            IQueryable<int> query = null;
            Assert.Throws<ArgumentNullException>(() => query.PageBy(0, 10));
        }

        [Theory]
        [InlineData(0, 3, new[] { 1, 2, 3 })]
        [InlineData(2, 2, new[] { 3, 4 })]
        [InlineData(4, 2, new[] { 5 })]
        [InlineData(10, 2, new int[0])]
        public void PageBy_Should_Return_Correct_Page(int skip, int take, int[] expected)
        {
            var source = Enumerable.Range(1, 5).AsQueryable();
            var result = source.PageBy(skip, take).ToArray();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PageBy_Should_Handle_Empty_Source()
        {
            var source = new List<int>().AsQueryable();
            var result = source.PageBy(0, 10).ToArray();
            Assert.Empty(result);
        }
    }
}
