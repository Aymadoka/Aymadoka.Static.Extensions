namespace Aymadoka.Static.ObjectExtension
{
    public class Object_IsNotNullTests
    {
        [Fact]
        public void IsNotNull_WithNonNullObject_ReturnsTrue()
        {
            string test = "hello";
            bool result = test.IsNotNull();
            Assert.True(result);
        }

        [Fact]
        public void IsNotNull_WithNullObject_ReturnsFalse()
        {
            string test = null;
            bool result = test.IsNotNull();
            Assert.False(result);
        }
    }
}
