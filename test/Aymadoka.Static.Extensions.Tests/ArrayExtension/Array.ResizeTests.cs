namespace Aymadoka.Static.ArrayExtension
{
    public class Array_ResizeTests
    {
        [Fact]
        public void Resize_IncreaseSize_ReturnsArrayWithNewSizeAndOriginalContent()
        {
            byte[] original = { 1, 2, 3 };
            int newSize = 5;

            byte[] result = original.Resize(newSize);

            Assert.Equal(newSize, result.Length);
            Assert.Equal(1, result[0]);
            Assert.Equal(2, result[1]);
            Assert.Equal(3, result[2]);
            Assert.Equal(0, result[3]);
            Assert.Equal(0, result[4]);
        }

        [Fact]
        public void Resize_DecreaseSize_ReturnsArrayWithTruncatedContent()
        {
            byte[] original = { 1, 2, 3, 4, 5 };
            int newSize = 3;

            byte[] result = original.Resize(newSize);

            Assert.Equal(newSize, result.Length);
            Assert.Equal(1, result[0]);
            Assert.Equal(2, result[1]);
            Assert.Equal(3, result[2]);
        }

        [Fact]
        public void Resize_SameSize_ReturnsArrayWithSameContent()
        {
            byte[] original = { 1, 2, 3 };
            int newSize = 3;

            byte[] result = original.Resize(newSize);

            Assert.Equal(newSize, result.Length);
            Assert.Equal(original, result);
        }

        [Fact]
        public void Resize_ZeroSize_ReturnsEmptyArray()
        {
            byte[] original = { 1, 2, 3 };
            int newSize = 0;

            byte[] result = original.Resize(newSize);

            Assert.Empty(result);
        }

        [Fact]
        public void Resize_NegativeSize_ThrowsArgumentOutOfRangeException()
        {
            byte[] original = { 1, 2, 3 };
            int newSize = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => original.Resize(newSize));
        }
    }
}
