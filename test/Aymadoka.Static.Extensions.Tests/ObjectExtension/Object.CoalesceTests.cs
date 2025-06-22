namespace Aymadoka.Static.ObjectExtension
{
    public class Object_CoalesceTests
    {
        [Fact]
        public void Coalesce_ReturnsThis_WhenThisIsNotNull()
        {
            string value = "hello";
            string result = value.Coalesce("world", null);
            Assert.Equal("hello", result);
        }

        [Fact]
        public void Coalesce_ReturnsFirstNonNullValue_WhenThisIsNull()
        {
            string value = null;
            string result = value.Coalesce(null, "first", "second");
            Assert.Equal("first", result);
        }

        [Fact]
        public void Coalesce_ReturnsNull_WhenAllAreNull()
        {
            string value = null;
            string result = value.Coalesce(null, null);
            Assert.Null(result);
        }

        [Fact]
        public void Coalesce_ReturnsFirstNonNullValue_WhenThisAndSomeValuesAreNull()
        {
            string value = null;
            string result = value.Coalesce(null, null, "not null", "another");
            Assert.Equal("not null", result);
        }

        [Fact]
        public void Coalesce_ReturnsNull_WhenNoValuesProvidedAndThisIsNull()
        {
            string value = null;
            string result = value.Coalesce();
            Assert.Null(result);
        }
    }
}
