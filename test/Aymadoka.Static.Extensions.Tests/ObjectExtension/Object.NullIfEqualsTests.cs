namespace Aymadoka.Static.ObjectExtension
{
    public class Object_NullIfEqualsTests
    {
        [Fact]
        public void NullIfEquals_ReturnsNull_WhenObjectsAreEqual()
        {
            string a = "test";
            string b = "test";

            var result = a.NullIfEquals(b);

            Assert.Null(result);
        }

        [Fact]
        public void NullIfEquals_ReturnsObject_WhenObjectsAreNotEqual()
        {
            string a = "test1";
            string b = "test2";

            var result = a.NullIfEquals(b);

            Assert.Equal(a, result);
        }

        [Fact]
        public void NullIfEquals_ReturnsObject_WhenComparedWithNull()
        {
            string a = "test";
            string b = null;

            var result = a.NullIfEquals(b);

            Assert.Equal(a, result);
        }

        [Fact]
        public void NullIfEquals_Throws_WhenThisIsNull()
        {
            string a = null;
            string b = "test";

            Assert.Throws<NullReferenceException>(() => a.NullIfEquals(b));
        }
    }
}
