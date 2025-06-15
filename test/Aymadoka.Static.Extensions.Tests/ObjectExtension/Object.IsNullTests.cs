namespace Aymadoka.Static.ObjectExtension
{
    public class Object_IsNullTests
    {
        [Fact]
        public void IsNull_WithNullReference_ReturnsTrue()
        {
            string? value = null;
            Assert.True(value.IsNull());
        }

        [Fact]
        public void IsNull_WithNonNullReference_ReturnsFalse()
        {
            string? value = "test";
            Assert.False(value.IsNull());
        }

        [Fact]
        public void IsNull_WithNullObject_ReturnsTrue()
        {
            object? obj = null;
            Assert.True(obj.IsNull());
        }

        [Fact]
        public void IsNull_WithNonNullObject_ReturnsFalse()
        {
            object? obj = new object();
            Assert.False(obj.IsNull());
        }
    }
}
