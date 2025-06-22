namespace Aymadoka.Static.ObjectExtension
{
    public class Object_NullIfTests
    {
        [Fact]
        public void NullIf_PredicateTrue_ReturnsNull()
        {
            string value = "test";
            var result = value.NullIf(v => v == "test");
            Assert.Null(result);
        }

        [Fact]
        public void NullIf_PredicateFalse_ReturnsOriginal()
        {
            string value = "test";
            var result = value.NullIf(v => v == "other");
            Assert.Equal("test", result);
        }

        [Fact]
        public void NullIf_NullObject_PredicateHandlesNull()
        {
            string value = null;
            var result = value.NullIf(v => v == null);
            Assert.Null(result);
        }

        [Fact]
        public void NullIf_NullPredicate_ThrowsArgumentNullException()
        {
            string value = "test";
            Assert.Throws<NullReferenceException>(() => value.NullIf(null));
        }
    }
}
