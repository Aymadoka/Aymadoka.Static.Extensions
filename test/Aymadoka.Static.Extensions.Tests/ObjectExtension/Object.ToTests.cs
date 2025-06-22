namespace Aymadoka.Static.ObjectExtension
{
    public class Object_ToTeststExtensions
    {
        [Fact]
        public void To_Generic_SameType_ReturnsOriginal()
        {
            int value = 42;
            int result = value.To<int>();
            Assert.Equal(value, result);
        }

        [Fact]
        public void To_Generic_ConvertibleType_ReturnsConverted()
        {
            string value = "123";
            int result = value.To<int>();
            Assert.Equal(123, result);
        }

        [Fact]
        public void To_Generic_DBNull_ReturnsNull()
        {
            object value = DBNull.Value;
            string result = value.To<string>();
            Assert.Null(result);
        }

        [Fact]
        public void To_Generic_Null_ReturnsNull()
        {
            object value = null;
            string result = value.To<string>();
            Assert.Null(result);
        }

        [Fact]
        public void To_NonGeneric_SameType_ReturnsOriginal()
        {
            int value = 42;
            object result = value.To(typeof(int));
            Assert.Equal(value, result);
        }

        [Fact]
        public void To_NonGeneric_ConvertibleType_ReturnsConverted()
        {
            string value = "456";
            object result = value.To(typeof(int));
            Assert.Equal(456, result);
        }

        [Fact]
        public void To_NonGeneric_DBNull_ReturnsNull()
        {
            object value = DBNull.Value;
            object result = value.To(typeof(string));
            Assert.Null(result);
        }

        [Fact]
        public void To_NonGeneric_Null_ReturnsNull()
        {
            object value = null;
            object result = value.To(typeof(string));
            Assert.Null(result);
        }

        [Fact]
        public void To_Generic_CannotConvert_ReturnsOriginal()
        {
            object value = new Object_ToTeststExtensions();
            var result = value.To<Object_ToTeststExtensions>();
            Assert.Equal(value, result);
        }

        [Fact]
        public void To_NonGeneric_CannotConvert_ReturnsOriginal()
        {
            object value = new Object_ToTeststExtensions();
            object result = value.To(typeof(Object_ToTeststExtensions));
            Assert.Equal(value, result);
        }
    }
}
