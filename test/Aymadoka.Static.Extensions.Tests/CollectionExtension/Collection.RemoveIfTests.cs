namespace Aymadoka.Static.CollectionExtension
{
    public class Collection_RemoveIfTests
    {
        [Fact]
        public void RemoveIf_RemovesElement_WhenPredicateIsTrue()
        {
            var list = new List<int> { 1, 2, 3 };
            list.RemoveIf(2, x => x == 2);
            Assert.DoesNotContain(2, list);
        }

        [Fact]
        public void RemoveIf_DoesNotRemoveElement_WhenPredicateIsFalse()
        {
            var list = new List<int> { 1, 2, 3 };
            list.RemoveIf(2, x => x == 3);
            Assert.Contains(2, list);
        }

        [Fact]
        public void RemoveIf_DoesNothing_WhenElementNotInCollection()
        {
            var list = new List<int> { 1, 2, 3 };
            list.RemoveIf(4, x => x == 4);
            Assert.Equal(3, list.Count);
        }

        [Fact]
        public void RemoveIf_WorksWithReferenceTypes()
        {
            var obj1 = new TestClass { Value = 1 };
            var obj2 = new TestClass { Value = 2 };
            var list = new List<TestClass> { obj1, obj2 };
            list.RemoveIf(obj2, x => x.Value == 2);
            Assert.DoesNotContain(obj2, list);
        }

        private class TestClass
        {
            public int Value { get; set; }
        }
    }
}
