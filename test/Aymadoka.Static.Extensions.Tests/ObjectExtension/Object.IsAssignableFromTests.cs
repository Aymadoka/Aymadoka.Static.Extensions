namespace Aymadoka.Static.ObjectExtension
{
    public class Object_IsAssignableFromTests
    {
        [Fact]
        public void IsAssignableFrom_Generic_ReturnsTrue_WhenAssignable()
        {
            object str = "test";

            var act1 = str.IsAssignableFrom<string>();
            var act2 = str.IsAssignableFrom<object>();


            Assert.True(act1);
            Assert.False(act2);
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

            var act1 = list.IsAssignableFrom(typeof(System.Collections.IEnumerable));
            var act2 = list.IsAssignableFrom(typeof(object));

            Assert.False(act1);
            Assert.False(act2);
        }

        [Fact]
        public void IsAssignableFrom_Type_ReturnsFalse_WhenNotAssignable()
        {
            object number = 123;

            var act = number.IsAssignableFrom(typeof(string));
            
            Assert.False(act);
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
            obj.IsAssignableFrom(null);
        }
    }
}
