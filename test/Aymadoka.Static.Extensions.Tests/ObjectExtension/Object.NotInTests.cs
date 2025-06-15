namespace Aymadoka.Static.ObjectExtension
{
    public class Object_NotInTests
    {
        [Fact]
        public void NotIn_ShouldReturnTrue_WhenValueNotInArray()
        {
            int value = 5;
            bool result = value.NotIn(1, 2, 3, 4);
            Assert.True(result);
        }

        [Fact]
        public void NotIn_ShouldReturnFalse_WhenValueInArray()
        {
            string value = "hello";
            bool result = value.NotIn("world", "hello", "test");
            Assert.False(result);
        }

        [Fact]
        public void NotIn_ShouldReturnTrue_WhenArrayIsEmpty()
        {
            double value = 3.14;
            bool result = value.NotIn();
            Assert.True(result);
        }

        [Fact]
        public void NotIn_ShouldHandleNullValue()
        {
            string value = null;
            bool result = value.NotIn("a", "b", null);
            Assert.False(result);
        }

        [Fact]
        public void NotIn_ShouldHandleNullArray()
        {
            string value = "a";
            string[] values = null;
            // params 允许传递 null，但 Array.IndexOf(null, ...) 会抛异常
            Assert.Throws<ArgumentNullException>(() => value.NotIn(values));
        }
    }
}
