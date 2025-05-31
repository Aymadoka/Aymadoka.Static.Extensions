using System.Collections.Generic;
using System.Linq;

namespace Aymadoka.Static.CollectionExtension
{
    public class Collection_SwapTests
    {
        [Fact]
        public void Swap_ReplacesAllMatchingElements_InIList()
        {
            var list = new List<int> { 1, 2, 3, 2, 4, 2 };
            list.Swap(2, 9);
            Assert.Equal(new List<int> { 1, 9, 3, 9, 4, 9 }, list);
        }

        [Fact]
        public void Swap_ReplacesAllMatchingElements_InICollection()
        {
            ICollection<string> set = new HashSet<string> { "a", "b", "c" };
            set.Swap("b", "z");
            Assert.Contains("z", set);
            Assert.DoesNotContain("b", set);
            Assert.Equal(3, set.Count);
        }

        [Fact]
        public void Swap_NoMatch_DoesNothing()
        {
            var list = new List<int> { 1, 2, 3 };
            list.Swap(5, 9);
            Assert.Equal(new List<int> { 1, 2, 3 }, list);
        }

        [Fact]
        public void Swap_AllElementsMatch_ReplacesAll()
        {
            var list = new List<int> { 7, 7, 7 };
            list.Swap(7, 0);
            Assert.Equal(new List<int> { 0, 0, 0 }, list);
        }

        [Fact]
        public void Swap_EmptyCollection_DoesNothing()
        {
            var list = new List<int>();
            list.Swap(1, 2);
            Assert.Empty(list);
        }
    }
}
