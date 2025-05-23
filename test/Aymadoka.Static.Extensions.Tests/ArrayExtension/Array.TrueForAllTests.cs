namespace Aymadoka.Static.ArrayExtension
{
    public class Array_TrueForAllTests
    {

        [Fact]
        public void TrueForAll_AllMatch_ReturnsTrue()
        {

            

            int[] arr = { 2, 4, 6 };
            bool result = ArrayExtensions.TrueForAll(arr, x => x % 2 == 0);
            Assert.True(result);
        }

        [Fact]
        public void TrueForAll_NotAllMatch_ReturnsFalse()
        {
            int[] arr = { 2, 3, 4 };
            bool result = ArrayExtensions.TrueForAll(arr, x => x % 2 == 0);
            Assert.False(result);
        }

        [Fact]
        public void TrueForAll_EmptyArray_ReturnsTrue()
        {
            int[] arr = Array.Empty<int>();
            bool result = ArrayExtensions.TrueForAll(arr, x => x > 0);
            Assert.True(result);
        }

        [Fact]
        public void TrueForAll_NullArray_ThrowsArgumentNullException()
        {
            int[] arr = null;
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.TrueForAll(arr, x => true));
        }

        [Fact]
        public void TrueForAll_NullPredicate_ThrowsArgumentNullException()
        {
            int[] arr = { 1, 2, 3 };
            Predicate<int> predicate = null;
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.TrueForAll(arr, predicate));
        }

        [Fact]
        public void TrueForAll_ReferenceType_AllNulls_ReturnsTrue()
        {
            string[] arr = { null, null };
            bool result = ArrayExtensions.TrueForAll(arr, x => x == null);
            Assert.True(result);
        }

        [Fact]
        public void TrueForAll_ReferenceType_SomeNulls_ReturnsFalse()
        {
            string[] arr = { "a", null };
            bool result = ArrayExtensions.TrueForAll(arr, x => x == null);
            Assert.False(result);
        }
    }
}
