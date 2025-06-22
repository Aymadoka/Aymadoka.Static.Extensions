namespace Aymadoka.Static.DelegateExtension
{
    public class Delegate_RemoveTests
    {
        private delegate int TestDelegate(int x);

        private int AddOne(int x) => x + 1;
        private int AddTwo(int x) => x + 2;

        [Fact]
        public void RemoveAll_RemovesAllMatchingDelegates()
        {
            TestDelegate d1 = AddOne;
            TestDelegate d2 = AddTwo;
            TestDelegate d3 = AddOne;

            var combined = (TestDelegate)Delegate.Combine(d1, d2, d3, d1);
            // combined: AddOne, AddTwo, AddOne, AddOne

            var removed = (TestDelegate?)combined.RemoveAll(d1);
            // 应该移除所有 AddOne，只剩 AddTwo

            Assert.NotNull(removed);
            var invocationList = removed!.GetInvocationList();
            Assert.Single(invocationList);
            Assert.Equal(nameof(AddTwo), invocationList[0].Method.Name);
        }

        [Fact]
        public void RemoveAll_NoMatch_ReturnsOriginalDelegate()
        {
            TestDelegate d1 = AddOne;
            TestDelegate d2 = AddTwo;

            var combined = (TestDelegate)Delegate.Combine(d1, d2);
            // combined: AddOne, AddTwo

            TestDelegate d3 = x => x * 2;
            var removed = combined.RemoveAll(d3);

            Assert.Same(combined, removed);
        }

        [Fact]
        public void RemoveAll_AllRemoved_ReturnsNull()
        {
            TestDelegate d1 = AddOne;
            var removed = d1.RemoveAll(d1);
            Assert.Null(removed);
        }

        [Fact]
        public void RemoveAll_NullSource_ThrowsArgumentNullException()
        {
            TestDelegate? source = null;
            TestDelegate d1 = AddOne;
            Assert.Throws<ArgumentNullException>(() => source!.RemoveAll(d1));
        }

        [Fact]
        public void RemoveAll_NullValue_ReturnsOriginalDelegate()
        {
            TestDelegate d1 = AddOne;
            var result = d1.RemoveAll(null);
            Assert.Same(d1, result);
        }
    }
}
