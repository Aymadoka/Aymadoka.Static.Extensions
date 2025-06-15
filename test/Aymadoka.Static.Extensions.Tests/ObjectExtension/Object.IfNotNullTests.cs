namespace Aymadoka.Static.ObjectExtension
{
    public class Object_IfNotNullTests
    {
        [Fact]
        public void IfNotNull_Action_Executes_WhenNotNull()
        {
            string value = "test";
            bool executed = false;

            value.IfNotNull(v => executed = true);

            Assert.True(executed);
        }

        [Fact]
        public void IfNotNull_Action_DoesNotExecute_WhenNull()
        {
            string value = null;
            bool executed = false;

            value.IfNotNull(v => executed = true);

            Assert.False(executed);
        }

        [Fact]
        public void IfNotNull_Func_ReturnsResult_WhenNotNull()
        {
            string value = "abc";
            int result = value.IfNotNull(v => v.Length);

            Assert.Equal(3, result);
        }

        [Fact]
        public void IfNotNull_Func_ReturnsDefault_WhenNull()
        {
            string value = null;
            int result = value.IfNotNull(v => v.Length);

            Assert.Equal(0, result);
        }

        [Fact]
        public void IfNotNull_FuncWithDefaultValue_ReturnsResult_WhenNotNull()
        {
            string value = "abc";
            int result = value.IfNotNull(v => v.Length, -1);

            Assert.Equal(3, result);
        }

        [Fact]
        public void IfNotNull_FuncWithDefaultValue_ReturnsDefault_WhenNull()
        {
            string value = null;
            int result = value.IfNotNull(v => v.Length, -1);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void IfNotNull_FuncWithFactory_ReturnsResult_WhenNotNull()
        {
            string value = "abc";
            int result = value.IfNotNull(v => v.Length, () => -2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void IfNotNull_FuncWithFactory_ReturnsFactoryResult_WhenNull()
        {
            string value = null;
            int result = value.IfNotNull(v => v.Length, () => -2);

            Assert.Equal(-2, result);
        }
    }
}
