namespace Aymadoka.Static.CollectionExtension
{
    public class Collection_RemoveIfContainsTests
    {
        [Fact]
        public void RemoveIfContains_RemovesItem_WhenItemExists()
        {
            var list = new List<int> { 1, 2, 3 };
            list.RemoveIfContains(2);
            Assert.DoesNotContain(2, list);
            Assert.Equal(2, list.Count);
        }

        [Fact]
        public void RemoveIfContains_DoesNothing_WhenItemDoesNotExist()
        {
            var list = new List<int> { 1, 2, 3 };
            list.RemoveIfContains(4);
            Assert.Equal(3, list.Count);
            Assert.Contains(1, list);
            Assert.Contains(2, list);
            Assert.Contains(3, list);
        }

        [Fact]
        public void RemoveIfContains_WorksWithReferenceTypes()
        {
            var strList = new List<string> { "a", "b", "c" };
            strList.RemoveIfContains("b");
            Assert.DoesNotContain("b", strList);
            Assert.Equal(2, strList.Count);
        }

        [Fact]
        public void RemoveIfContains_DoesNothing_WhenCollectionIsEmpty()
        {
            var emptyList = new List<int>();
            emptyList.RemoveIfContains(1);
            Assert.Empty(emptyList);
        }
    }
}
