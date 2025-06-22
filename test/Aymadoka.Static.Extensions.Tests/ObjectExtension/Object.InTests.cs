namespace Aymadoka.Static.ObjectExtension
{
    public class Object_InTests
    {
        [Fact]
        public void In_ShouldReturnTrue_WhenValueIsInArray()
        {
            int value = 2;
            bool result = value.In(1, 2, 3);
            Assert.True(result);
        }

        [Fact]
        public void In_ShouldReturnFalse_WhenValueIsNotInArray()
        {
            string value = "hello";
            bool result = value.In("world", "test", "foo");
            Assert.False(result);
        }

        [Fact]
        public void In_ShouldReturnFalse_WhenArrayIsEmpty()
        {
            double value = 1.23;
            bool result = value.In();
            Assert.False(result);
        }

        [Fact]
        public void In_ShouldHandleNullValue()
        {
            string value = null;
            bool result = value.In("a", null, "b");
            Assert.True(result);
        }

        [Fact]
        public void In_ShouldHandleReferenceType()
        {
            object obj = new object();
            object[] arr = { new object(), obj };
            bool result = obj.In(arr);
            Assert.True(result);
        }
    }
}
