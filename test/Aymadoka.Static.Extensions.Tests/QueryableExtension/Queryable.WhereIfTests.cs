using System.Linq.Expressions;

namespace Aymadoka.Static.QueryableExtension
{
    public class Queryable_WhereIfTests
    {
        private IQueryable<int> GetTestQueryable()
        {
            return new List<int> { 1, 2, 3, 4, 5 }.AsQueryable();
        }

        [Fact]
        public void WhereIf_ConditionTrue_FiltersElements()
        {
            // Arrange
            var source = GetTestQueryable();
            Expression<Func<int, bool>> predicate = x => x > 2;

            // Act
            var result = source.WhereIf(predicate, true).ToList();

            // Assert
            Assert.Equal(new List<int> { 3, 4, 5 }, result);
        }

        [Fact]
        public void WhereIf_ConditionFalse_ReturnsOriginal()
        {
            // Arrange
            var source = GetTestQueryable();
            Expression<Func<int, bool>> predicate = x => x > 2;

            // Act
            var result = source.WhereIf(predicate, false).ToList();

            // Assert
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, result);
        }

        [Fact]
        public void WhereIf_WithIndex_ConditionTrue_FiltersElements()
        {
            // Arrange
            var source = GetTestQueryable();
            Expression<Func<int, int, bool>> predicate = (x, idx) => idx % 2 == 0;

            // Act
            var result = source.WhereIf(predicate, true).ToList();

            // Assert
            Assert.Equal(new List<int> { 1, 3, 5 }, result);
        }

        [Fact]
        public void WhereIf_WithIndex_ConditionFalse_ReturnsOriginal()
        {
            // Arrange
            var source = GetTestQueryable();
            Expression<Func<int, int, bool>> predicate = (x, idx) => idx % 2 == 0;

            // Act
            var result = source.WhereIf(predicate, false).ToList();

            // Assert
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, result);
        }
    }
}
