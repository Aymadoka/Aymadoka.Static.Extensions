namespace Aymadoka.Static.ArrayExtension
{
    public class Array_SortTests
    {
        [Fact]
        public void Sort_GenericArray_SortsAscending()
        {
            int[] arr = { 3, 1, 2 };
            arr.Sort();
            Assert.Equal(new[] { 1, 2, 3 }, arr);
        }

        [Fact]
        public void Sort_GenericArray_Null_Throws()
        {
            int[] arr = null;
            Assert.Throws<ArgumentNullException>(() => arr.Sort());
        }

        [Fact]
        public void Sort_KeyValue_SortsBoth()
        {
            int[] keys = { 3, 1, 2 };
            string[] values = { "c", "a", "b" };
            keys.Sort(values);
            Assert.Equal(new[] { 1, 2, 3 }, keys);
            Assert.Equal(new[] { "a", "b", "c" }, values);
        }

        [Fact]
        public void Sort_KeyValue_NullKeys_Throws()
        {
            int[] keys = null;
            string[] values = { "a" };
            Assert.Throws<ArgumentNullException>(() => keys.Sort(values));
        }

        [Fact]
        public void Sort_KeyValue_LengthMismatch_Throws()
        {
            int[] keys = { 1, 2 };
            string[] values = { "a" };
            Assert.Throws<ArgumentException>(() => keys.Sort(values));
        }

        [Fact]
        public void Sort_GenericArray_Range_SortsPartial()
        {
            int[] arr = { 5, 3, 4, 1, 2 };
            arr.Sort(1, 3);
            Assert.Equal(new[] { 5, 1, 3, 4, 2 }, arr);
        }

        [Fact]
        public void Sort_GenericArray_Range_Null_Throws()
        {
            int[] arr = null;
            Assert.Throws<ArgumentNullException>(() => arr.Sort(0, 1));
        }

        [Theory]
        [InlineData(-1, 1)]
        [InlineData(0, -1)]
        public void Sort_GenericArray_Range_Negative_Throws(int index, int length)
        {
            int[] arr = { 1, 2, 3 };
            Assert.Throws<ArgumentOutOfRangeException>(() => arr.Sort(index, length));
        }

        [Fact]
        public void Sort_GenericArray_Range_Invalid_Throws()
        {
            int[] arr = { 1, 2, 3 };
            Assert.Throws<ArgumentException>(() => arr.Sort(2, 5));
        }

        [Fact]
        public void Sort_KeyValue_Range_SortsPartial()
        {
            int[] keys = { 5, 3, 4, 1, 2 };
            string[] values = { "e", "c", "d", "a", "b" };
            keys.Sort(values, 1, 3);
            Assert.Equal(new[] { 5, 1, 3, 4, 2 }, keys);
            Assert.Equal(new[] { "e", "a", "c", "d", "b" }, values);
        }

        [Fact]
        public void Sort_KeyValue_Range_NullKeys_Throws()
        {
            int[] keys = null;
            string[] values = { "a" };
            Assert.Throws<ArgumentNullException>(() => keys.Sort(values, 0, 1));
        }

        [Theory]
        [InlineData(-1, 1)]
        [InlineData(0, -1)]
        public void Sort_KeyValue_Range_Negative_Throws(int index, int length)
        {
            int[] keys = { 1, 2, 3 };
            string[] values = { "a", "b", "c" };
            Assert.Throws<ArgumentOutOfRangeException>(() => keys.Sort(values, index, length));
        }

        [Fact]
        public void Sort_KeyValue_Range_Invalid_Throws()
        {
            int[] keys = { 1, 2, 3 };
            string[] values = { "a", "b", "c" };
            Assert.Throws<ArgumentException>(() => keys.Sort(values, 2, 5));
        }

        [Fact]
        public void Sort_GenericArray_WithComparer_Sorts()
        {
            int[] arr = { 1, 3, 2 };
            var comparer = Comparer<int>.Default;
            arr.Sort(comparer);
            Assert.Equal(new[] { 1, 2, 3 }, arr);
        }

        [Fact]
        public void Sort_GenericArray_WithComparer_Null_Throws()
        {
            int[] arr = null;
            var comparer = Comparer<int>.Default;
            Assert.Throws<ArgumentNullException>(() => arr.Sort(comparer));
        }

        [Fact]
        public void Sort_Array_WithComparer_Sorts()
        {
            Array keys = new int[] { 3, 1, 2 };
            Array items = new string[] { "c", "a", "b" };
            var comparer = Comparer<int>.Default;
            keys.Sort(items, comparer);
            Assert.Equal(new int[] { 1, 2, 3 }, (int[])keys);
            Assert.Equal(new string[] { "a", "b", "c" }, (string[])items);
        }

        [Fact]
        public void Sort_Array_WithComparer_NullKeys_Throws()
        {
            Array keys = null;
            Array items = new string[] { "a" };
            var comparer = Comparer<int>.Default;
            Assert.Throws<ArgumentNullException>(() => keys.Sort(items, comparer));
        }

        [Fact]
        public void Sort_Array_WithComparer_LengthMismatch_Throws()
        {
            Array keys = new int[] { 1, 2 };
            Array items = new string[] { "a" };
            var comparer = Comparer<int>.Default;
            Assert.Throws<ArgumentException>(() => keys.Sort(items, comparer));
        }

        [Fact]
        public void Sort_GenericArray_Range_WithComparer_SortsPartial()
        {
            int[] arr = { 5, 3, 4, 1, 2 };
            var comparer = Comparer<int>.Default;
            arr.Sort(1, 3, comparer);
            Assert.Equal(new[] { 5, 1, 3, 4, 2 }, arr);
        }

        [Fact]
        public void Sort_GenericArray_Range_WithComparer_Null_Throws()
        {
            int[] arr = null;
            var comparer = Comparer<int>.Default;
            Assert.Throws<ArgumentNullException>(() => arr.Sort(0, 1, comparer));
        }

        [Theory]
        [InlineData(-1, 1)]
        [InlineData(0, -1)]
        public void Sort_GenericArray_Range_WithComparer_Negative_Throws(int index, int length)
        {
            int[] arr = { 1, 2, 3 };
            var comparer = Comparer<int>.Default;
            Assert.Throws<ArgumentOutOfRangeException>(() => arr.Sort(index, length, comparer));
        }

        [Fact]
        public void Sort_GenericArray_Range_WithComparer_Invalid_Throws()
        {
            int[] arr = { 1, 2, 3 };
            var comparer = Comparer<int>.Default;
            Assert.Throws<ArgumentException>(() => arr.Sort(2, 5, comparer));
        }

        [Fact]
        public void Sort_Array_Range_WithComparer_SortsPartial()
        {
            Array keys = new int[] { 5, 3, 4, 1, 2 };
            Array items = new string[] { "e", "c", "d", "a", "b" };
            var comparer = Comparer<int>.Default;
            keys.Sort(items, 1, 3, comparer);
            Assert.Equal(new int[] { 5, 1, 3, 4, 2 }, (int[])keys);
            Assert.Equal(new string[] { "e", "a", "c", "d", "b" }, (string[])items);
        }

        [Fact]
        public void Sort_Array_Range_WithComparer_NullKeys_Throws()
        {
            Array keys = null;
            Array items = new string[] { "a" };
            var comparer = Comparer<int>.Default;
            Assert.Throws<ArgumentNullException>(() => keys.Sort(items, 0, 1, comparer));
        }

        [Theory]
        [InlineData(-1, 1)]
        [InlineData(0, -1)]
        public void Sort_Array_Range_WithComparer_Negative_Throws(int index, int length)
        {
            Array keys = new int[] { 1, 2, 3 };
            Array items = new string[] { "a", "b", "c" };
            var comparer = Comparer<int>.Default;
            Assert.Throws<ArgumentOutOfRangeException>(() => keys.Sort(items, index, length, comparer));
        }

        [Fact]
        public void Sort_Array_Range_WithComparer_Invalid_Throws()
        {
            Array keys = new int[] { 1, 2, 3 };
            Array items = new string[] { "a", "b", "c" };
            var comparer = Comparer<int>.Default;
            Assert.Throws<ArgumentException>(() => keys.Sort(items, 2, 5, comparer));
        }
    }
}
