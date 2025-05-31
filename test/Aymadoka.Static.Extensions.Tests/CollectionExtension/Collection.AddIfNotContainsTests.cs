using System.Collections.Generic;

namespace Aymadoka.Static.CollectionExtension
{
    public class Collection_AddIfNotContainsTests
    {
        [Fact]
        public void AddIfNotContains_ShouldAdd_WhenValueNotPresent()
        {
            var list = new List<int> { 1, 2, 3 };
            bool result = list.AddIfNotContains(4);

            Assert.True(result);
            Assert.Contains(4, list);
        }

        [Fact]
        public void AddIfNotContains_ShouldNotAdd_WhenValueAlreadyPresent()
        {
            var list = new List<int> { 1, 2, 3 };
            bool result = list.AddIfNotContains(2);

            Assert.False(result);
            Assert.Equal(3, list.Count);
        }

        [Fact]
        public void AddIfNotContains_ShouldWorkWithReferenceTypes()
        {
            var list = new List<string> { "a", "b" };
            bool result = list.AddIfNotContains("c");

            Assert.True(result);
            Assert.Contains("c", list);
        }

        [Fact]
        public void AddIfNotContains_ShouldNotAddNullIfAlreadyPresent()
        {
            var list = new List<string> { null, "a" };
            bool result = list.AddIfNotContains(null);

            Assert.False(result);
            Assert.Equal(2, list.Count);
        }

        [Fact]
        public void AddIfNotContains_ShouldAddNullIfNotPresent()
        {
            var list = new List<string> { "a", "b" };
            bool result = list.AddIfNotContains(null);

            Assert.True(result);
            Assert.Contains(null, list);
        }
    }
}
