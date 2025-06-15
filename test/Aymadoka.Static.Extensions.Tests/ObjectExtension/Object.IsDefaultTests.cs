namespace Aymadoka.Static.ObjectExtension
{
    public class Object_IsDefaultTests
    {
        [Fact]
        public void IsDefault_Int_DefaultValue_ReturnsTrue()
        {
            int value = default;
            Assert.True(value.IsDefault());
        }

        [Fact]
        public void IsDefault_Int_NonDefaultValue_ReturnsFalse()
        {
            int value = 42;
            Assert.False(value.IsDefault());
        }

        [Fact]
        public void IsDefault_String_DefaultValue_ReturnsTrue()
        {
            string value = default;
            Assert.True(value.IsDefault());
        }

        [Fact]
        public void IsDefault_String_NonDefaultValue_ReturnsFalse()
        {
            string value = "test";
            Assert.False(value.IsDefault());
        }

        [Fact]
        public void IsDefault_CustomStruct_DefaultValue_ReturnsTrue()
        {
            var value = default(MyStruct);
            Assert.True(value.IsDefault());
        }

        [Fact]
        public void IsDefault_CustomStruct_NonDefaultValue_ReturnsFalse()
        {
            var value = new MyStruct { X = 1 };
            Assert.False(value.IsDefault());
        }

        struct MyStruct
        {
            public int X;
        }
    }
}
