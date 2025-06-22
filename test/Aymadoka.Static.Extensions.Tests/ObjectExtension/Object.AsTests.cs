namespace Aymadoka.Static.ObjectExtension
{
    public class Object_AsTests
    {
        [Fact]
        public void As_WithValidCast_ReturnsCastedValue()
        {
            object value = "test";
            var result = value.As<string>();
            Assert.Equal("test", result);
        }

        [Fact]
        public void As_WithInvalidCast_ThrowsInvalidCastException()
        {
            object value = "test";
            Assert.Throws<InvalidCastException>(() => value.As<int>());
        }

        [Fact]
        public void As_WithNullReference_ReturnsNull()
        {
            object value = null;
            string result = value.As<string>();
            Assert.Null(result);
        }
    }
}
