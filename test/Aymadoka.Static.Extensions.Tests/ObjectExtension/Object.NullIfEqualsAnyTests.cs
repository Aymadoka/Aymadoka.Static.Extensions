namespace Aymadoka.Static.ObjectExtension
{
    public class Object_NullIfEqualsAnyTests
    {
        [Fact]
        public void NullIfEqualsAny_ReturnsNull_WhenEqualsAnyValue()
        {
            string value = "test";
            string[] values = { "a", "b", "test", "c" };

            var result = value.NullIfEqualsAny(values);

            Assert.Null(result);
        }

        [Fact]
        public void NullIfEqualsAny_ReturnsOriginal_WhenNotEqualsAnyValue()
        {
            string value = "hello";
            string[] values = { "a", "b", "c" };

            var result = value.NullIfEqualsAny(values);

            Assert.Equal(value, result);
        }

        [Fact]
        public void NullIfEqualsAny_ReturnsNull_WhenValueIsNullAndValuesContainNull()
        {
            string value = null;
            string[] values = { null, "a", "b" };

            var result = value.NullIfEqualsAny(values);

            Assert.Null(result);
        }

        [Fact]
        public void NullIfEqualsAny_ReturnsOriginal_WhenValuesIsEmpty()
        {
            string value = "test";

            var result = value.NullIfEqualsAny();

            Assert.Equal(value, result);
        }

        [Fact]
        public void NullIfEqualsAny_WorksWithReferenceTypes()
        {
            object obj = new object();
            object[] values = { new object(), obj };

            var result = obj.NullIfEqualsAny(values);

            Assert.Null(result);
        }
    }
}
