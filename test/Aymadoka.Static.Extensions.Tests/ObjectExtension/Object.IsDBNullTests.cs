namespace Aymadoka.Static.ObjectExtension
{
    public class Object_IsDBNullTests
    {
        public class ObjectExtensions_IsDBNull_Tests
        {
            [Fact]
            public void IsDBNull_WithDBNullValue_ReturnsTrue()
            {
                object dbNullValue = DBNull.Value;
                Assert.True(dbNullValue.IsDBNull());
            }

            [Fact]
            public void IsDBNull_WithNullValue_ReturnsFalse()
            {
                object nullValue = null;
                Assert.False(nullValue.IsDBNull());
            }

            [Fact]
            public void IsDBNull_WithNonDBNullObject_ReturnsFalse()
            {
                object str = "test";
                Assert.False(str.IsDBNull());
            }

            [Fact]
            public void IsDBNull_WithNonDBNullReferenceType_ReturnsFalse()
            {
                var obj = new TestClass();
                Assert.False(obj.IsDBNull());
            }

            private class TestClass { }
        }
    }
}
