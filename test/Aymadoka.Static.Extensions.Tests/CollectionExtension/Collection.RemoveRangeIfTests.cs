namespace Aymadoka.Static.CollectionExtension
{
    public class Collection_RemoveRangeIfTests
    {
        [Fact]
        public void RemoveRangeIf_RemovesMatchingValues()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3, 4, 5 };
            // Act
            list.RemoveRangeIf(x => x % 2 == 0, 2, 3, 4);
            // Assert
            Assert.DoesNotContain(2, list);
            Assert.DoesNotContain(4, list);
            Assert.Contains(3, list); // 3 is not even, should remain
        }

        [Fact]
        public void RemoveRangeIf_DoesNotRemoveWhenPredicateFalse()
        {
            var list = new List<string> { "a", "b", "c" };
            list.RemoveRangeIf(s => s == "z", "a", "b");
            Assert.Contains("a", list);
            Assert.Contains("b", list);
            Assert.Contains("c", list);
        }

        [Fact]
        public void RemoveRangeIf_RemovesOnlySpecifiedValues()
        {
            var set = new HashSet<int> { 1, 2, 3, 4 };
            set.RemoveRangeIf(x => x > 2, 2, 3, 4, 5);
            Assert.Contains(1, set);
            Assert.Contains(2, set); // 2 is not > 2
            Assert.DoesNotContain(3, set);
            Assert.DoesNotContain(4, set);
        }

        [Fact]
        public void RemoveRangeIf_EmptyValues_NoEffect()
        {
            var list = new List<int> { 1, 2, 3 };
            list.RemoveRangeIf(x => true);
            Assert.Equal(new List<int> { 1, 2, 3 }, list);
        }

        [Fact]
        public void RemoveRangeIf_NullPredicate_Throws()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.Throws<NullReferenceException>(() => list.RemoveRangeIf(null, 1, 2));
        }
    }
}
