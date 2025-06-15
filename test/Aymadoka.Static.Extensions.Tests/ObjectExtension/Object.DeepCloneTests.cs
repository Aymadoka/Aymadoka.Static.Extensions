namespace Aymadoka.Static.ObjectExtension
{
    public class Object_DeepCloneTests
    {
        private class TestClass
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public NestedClass Nested { get; set; }
        }

        private class NestedClass
        {
            public string Value { get; set; }
        }

        [Fact]
        public void DeepClone_ReturnsNull_WhenSourceIsNull()
        {
            TestClass obj = null;
            var clone = obj.DeepClone();
            Assert.Null(clone);
        }

        [Fact]
        public void DeepClone_ReturnsEqualObject_WhenSourceIsNotNull()
        {
            var obj = new TestClass
            {
                Id = 1,
                Name = "Test",
                Nested = new NestedClass { Value = "Nested" }
            };

            var clone = obj.DeepClone();

            Assert.NotNull(clone);
            Assert.Equal(obj.Id, clone.Id);
            Assert.Equal(obj.Name, clone.Name);
            Assert.NotNull(clone.Nested);
            Assert.Equal(obj.Nested.Value, clone.Nested.Value);
        }

        [Fact]
        public void DeepClone_ReturnsDifferentReference()
        {
            var obj = new TestClass
            {
                Id = 2,
                Name = "RefTest",
                Nested = new NestedClass { Value = "RefNested" }
            };

            var clone = obj.DeepClone();

            Assert.NotSame(obj, clone);
            Assert.NotSame(obj.Nested, clone.Nested);
        }
    }
}
