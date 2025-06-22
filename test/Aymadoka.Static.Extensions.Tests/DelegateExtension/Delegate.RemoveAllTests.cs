namespace Aymadoka.Static.DelegateExtension
{
    public class Delegate_RemoveAllTests
    {
        private delegate int TestDelegate(int x);

        private int AddOne(int x) => x + 1;
        private int AddTwo(int x) => x + 2;

        [Fact]
        public void Remove_ShouldRemoveLastMatchingDelegate2()
        {
            TestDelegate d1 = AddOne;
            TestDelegate d2 = AddTwo;
            TestDelegate combined = (TestDelegate)Delegate.Combine(d1, d2, d1);

            // 移除最后一个 AddOne
            var result = combined.Remove(d1);

            // 期望只剩下 AddOne, AddTwo
            var invocationList = result.GetInvocationList();
            Assert.Equal(2, invocationList.Length);

            Assert.True(d1.Equals(invocationList[0]));
            Assert.True(d2.Equals(invocationList[1]));
        }

        [Fact]
        public void Remove_ShouldReturnOriginalIfNotFound()
        {
            TestDelegate d1 = AddOne;
            TestDelegate d2 = AddTwo;
            TestDelegate combined = (TestDelegate)Delegate.Combine(d1, d2);

            // 尝试移除不存在的委托
            TestDelegate d3 = x => x * 2;
            var result = combined.Remove(d3);

            Assert.Same(combined, result);
        }

        [Fact]
        public void Remove_ShouldReturnNullIfSourceIsNull()
        {
            TestDelegate d1 = AddOne;
            Delegate source = null;

            var result = source.Remove(d1);

            Assert.Null(result);
        }
    }
}
