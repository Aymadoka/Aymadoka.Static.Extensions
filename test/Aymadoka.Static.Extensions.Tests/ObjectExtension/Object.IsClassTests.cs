namespace Aymadoka.Static.ObjectExtension
{
    public class Object_IsClassTests
    {
        [Fact]
        public void IsClass_WithClassInstance_ReturnsTrue()
        {
            var obj = new TestClass();
            Assert.True(obj.IsClass());
        }

        [Fact]
        public void IsClass_WithStructInstance_ReturnsFalse()
        {
            var obj = new TestStruct();
            Assert.False(obj.IsClass());
        }

        [Fact]
        public void IsClass_WithPrimitiveType_ReturnsFalse()
        {
            int value = 42;
            Assert.False(value.IsClass());
        }

        [Fact]
        public void IsClass_WithNull_ThrowsArgumentNullException()
        {
            TestClass obj = null;
            Assert.Throws<ArgumentNullException>(() => obj.IsClass());
        }

        private class TestClass { }
        private struct TestStruct { }
    }
}
