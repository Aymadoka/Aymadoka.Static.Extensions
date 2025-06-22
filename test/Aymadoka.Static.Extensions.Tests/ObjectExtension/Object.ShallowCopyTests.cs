using NSubstitute;
using Shouldly;
using System.Reflection;

namespace Aymadoka.Static.ObjectExtension
{
    public class Object_ShallowCopyTests
    {
        private class TestClass
        {
            public int Value { get; set; }
            public string Name { get; set; }
        }

        [Fact]
        public void ShallowCopy_ReturnsNull_WhenSourceIsNull()
        {
            TestClass obj = null;
            var copy = obj.ShallowCopy();
            Assert.Null(copy);
        }

        [Fact]
        public void ShallowCopy_ReturnsDifferentReference()
        {
            var obj = new TestClass { Value = 42, Name = "Test" };
            var copy = obj.ShallowCopy();
            Assert.NotNull(copy);
            Assert.NotSame(obj, copy);
        }

        [Fact]
        public void ShallowCopy_CopiesProperties()
        {
            var obj = new TestClass { Value = 123, Name = "Hello" };
            var copy = obj.ShallowCopy();
            Assert.Equal(obj.Value, copy.Value);
            Assert.Equal(obj.Name, copy.Name);
        }

        private struct TestStruct
        {
            public int X;
        }
    }
}
