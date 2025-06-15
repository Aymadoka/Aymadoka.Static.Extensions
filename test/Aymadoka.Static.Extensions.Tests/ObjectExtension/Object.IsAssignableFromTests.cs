namespace Aymadoka.Static.ObjectExtension
{
    public class Object_IsAssignableFromTests
    {
        [Fact]
        public void IsAssignableFrom_Generic_ReturnsTrue_WhenAssignable()
        {
            object str = "test";
            Assert.True(str.IsAssignableFrom<string>());
            Assert.True(str.IsAssignableFrom<object>());
        }

        [Fact]
        public void IsAssignableFrom_Generic_ReturnsFalse_WhenNotAssignable()
        {
            object str = "test";
            Assert.False(str.IsAssignableFrom<int>());
        }

        [Fact]
        public void IsAssignableFrom_Type_ReturnsTrue_WhenAssignable()
        {
            object list = new System.Collections.ArrayList();
            Assert.True(list.IsAssignableFrom(typeof(System.Collections.IEnumerable)));
            Assert.True(list.IsAssignableFrom(typeof(object)));
        }

        [Fact]
        public void IsAssignableFrom_Type_ReturnsFalse_WhenNotAssignable()
        {
            object number = 123;
            Assert.False(number.IsAssignableFrom(typeof(string)));
        }

        [Fact]
        public void IsAssignableFrom_ThrowsException_WhenObjectIsNull()
        {
            object obj = null;
            Assert.Throws<NullReferenceException>(() => obj.IsAssignableFrom<string>());
            Assert.Throws<NullReferenceException>(() => obj.IsAssignableFrom(typeof(string)));
        }

        [Fact]
        public void IsAssignableFrom_Type_ThrowsException_WhenTypeIsNull()
        {
            object obj = new object();
            Assert.Throws<ArgumentNullException>(() => obj.IsAssignableFrom(null));
        }
    }
}
