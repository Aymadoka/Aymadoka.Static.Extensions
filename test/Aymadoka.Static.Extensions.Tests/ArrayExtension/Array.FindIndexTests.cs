namespace Aymadoka.Static.ArrayExtension
{
    public class Array_FindIndexTests
    {
        [Fact]
        public void FindIndex_WithMatch_FindsCorrectIndex()
        {
            int[] array = { 1, 3, 5, 7, 9 };
            int index = ArrayExtensions.FindIndex(array, x => x == 5);
            Assert.Equal(2, index);
        }

        [Fact]
        public void FindIndex_WithMatch_NotFound_ReturnsMinusOne()
        {
            int[] array = { 1, 3, 5, 7, 9 };
            int index = ArrayExtensions.FindIndex(array, x => x == 100);
            Assert.Equal(-1, index);
        }

        [Fact]
        public void FindIndex_WithMatch_NullArray_Throws()
        {
            int[] array = null;
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.FindIndex(array, x => x == 1));
        }

        [Fact]
        public void FindIndex_WithMatch_NullPredicate_Throws()
        {
            int[] array = { 1, 2, 3 };
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.FindIndex(array, null));
        }

        [Fact]
        public void FindIndex_WithStartIndex_FindsCorrectIndex()
        {
            int[] array = { 1, 3, 5, 7, 9 };
            int index = ArrayExtensions.FindIndex(array, 2, x => x > 5);
            Assert.Equal(3, index);
        }

        [Fact]
        public void FindIndex_WithStartIndex_NotFound_ReturnsMinusOne()
        {
            int[] array = { 1, 3, 5, 7, 9 };
            int index = ArrayExtensions.FindIndex(array, 4, x => x < 0);
            Assert.Equal(-1, index);
        }

        [Fact]
        public void FindIndex_WithStartIndex_NullArray_Throws()
        {
            int[] array = null;
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.FindIndex(array, 0, x => x == 1));
        }

        [Fact]
        public void FindIndex_WithStartIndex_NullPredicate_Throws()
        {
            int[] array = { 1, 2, 3 };
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.FindIndex(array, 0, null));
        }

        [Fact]
        public void FindIndex_WithStartIndex_OutOfRange_Throws()
        {
            int[] array = { 1, 2, 3 };
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.FindIndex(array, -1, x => x == 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.FindIndex(array, 4, x => x == 1));
        }

        [Fact]
        public void FindIndex_WithStartIndexAndCount_FindsCorrectIndex()
        {
            int[] array = { 1, 3, 5, 7, 9 };
            int index = ArrayExtensions.FindIndex(array, 1, 3, x => x == 7);
            Assert.Equal(3, index);
        }

        [Fact]
        public void FindIndex_WithStartIndexAndCount_NotFound_ReturnsMinusOne()
        {
            int[] array = { 1, 3, 5, 7, 9 };
            int index = ArrayExtensions.FindIndex(array, 1, 2, x => x == 9);
            Assert.Equal(-1, index);
        }

        [Fact]
        public void FindIndex_WithStartIndexAndCount_NullArray_Throws()
        {
            int[] array = null;
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.FindIndex(array, 0, 1, x => x == 1));
        }

        [Fact]
        public void FindIndex_WithStartIndexAndCount_NullPredicate_Throws()
        {
            int[] array = { 1, 2, 3 };
            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.FindIndex(array, 0, 1, null));
        }

        [Fact]
        public void FindIndex_WithStartIndexAndCount_OutOfRange_Throws()
        {
            int[] array = { 1, 2, 3 };
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.FindIndex(array, -1, 2, x => x == 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.FindIndex(array, 0, 5, x => x == 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.FindIndex(array, 2, 2, x => x == 1));
        }
    }
}
