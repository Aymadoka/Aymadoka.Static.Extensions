namespace Aymadoka.Static.ObjectExtension
{
    public class Object_IsArrayTests
    {
        [Fact]
        public void IsArray_WithArray_ReturnsTrue()
        {
            int[] arr = { 1, 2, 3 };
            Assert.True(arr.IsArray());
        }

        [Fact]
        public void IsArray_WithNonArray_ReturnsFalse()
        {
            string str = "test";
            Assert.False(str.IsArray());
        }

        [Fact]
        public void IsArray_WithNull_ThrowsArgumentNullException()
        {
            object obj = null;
            Assert.Throws<ArgumentNullException>(() => obj.IsArray());
        }

        [Fact]
        public void IsArray_WithList_ReturnsFalse()
        {
            var list = new System.Collections.Generic.List<int> { 1, 2, 3 };
            Assert.False(list.IsArray());
        }

        [Fact]
        public void IsArray_WithMultiDimensionalArray_ReturnsTrue()
        {
            int[,] arr2d = new int[2, 2];
            Assert.True(arr2d.IsArray());
        }
    }
}
