namespace Aymadoka.Static.ObjectExtension
{
    public class Object_IsEnumTests
    {
        private enum TestEnum { A, B, C }
        private class TestClass { }

        [Fact]
        public void IsEnum_WithEnumValue_ReturnsTrue()
        {
            var value = TestEnum.A;
            Assert.True(value.IsEnum());
        }

        [Fact]
        public void IsEnum_WithNonEnumValue_ReturnsFalse()
        {
            var value = 123;
            Assert.False(value.IsEnum());
        }

        [Fact]
        public void IsEnum_WithString_ReturnsFalse()
        {
            var value = "test";
            Assert.False(value.IsEnum());
        }

        [Fact]
        public void IsEnum_WithClassInstance_ReturnsFalse()
        {
            var value = new TestClass();
            Assert.False(value.IsEnum());
        }

        [Fact]
        public void IsEnum_WithNull_ThrowsArgumentNullException()
        {
            object value = null;
            Assert.Throws<ArgumentNullException>(() => value.IsEnum());
        }
    }
}
