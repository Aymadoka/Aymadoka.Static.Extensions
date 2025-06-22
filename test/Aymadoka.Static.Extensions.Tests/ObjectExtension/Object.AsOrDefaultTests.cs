namespace Aymadoka.Static.ObjectExtension
{
    public class Object_AsOrDefaultTests
    {
        [Fact]
        public void AsOrDefault_ReturnsValue_WhenTypeMatches()
        {
            object input = 42;
            int result = input.AsOrDefault<int>();
            Assert.Equal(42, result);
        }

        [Fact]
        public void AsOrDefault_ReturnsDefault_WhenTypeDoesNotMatch()
        {
            object input = "not an int";
            int result = input.AsOrDefault<int>();
            Assert.Equal(default, result);
        }

        [Fact]
        public void AsOrDefault_WithDefaultValue_ReturnsValue_WhenTypeMatches()
        {
            object input = "hello";
            string result = input.AsOrDefault("default");
            Assert.Equal("hello", result);
        }

        [Fact]
        public void AsOrDefault_WithDefaultValue_ReturnsDefault_WhenTypeDoesNotMatch()
        {
            object input = 123;
            string result = input.AsOrDefault("default");
            Assert.Equal("default", result);
        }

        [Fact]
        public void AsOrDefault_WithFactory_ReturnsValue_WhenTypeMatches()
        {
            object input = 3.14;
            double result = input.AsOrDefault(() => 0.0);
            Assert.Equal(3.14, result);
        }

        [Fact]
        public void AsOrDefault_WithFactory_ReturnsFactoryValue_WhenTypeDoesNotMatch()
        {
            object input = "not a double";
            double result = input.AsOrDefault(() => 1.23);
            Assert.Equal(1.23, result);
        }

        [Fact]
        public void AsOrDefault_WithFactoryAndObject_ReturnsValue_WhenTypeMatches()
        {
            object input = true;
            bool result = input.AsOrDefault(obj => false);
            Assert.True(result);
        }

        [Fact]
        public void AsOrDefault_WithFactoryAndObject_ReturnsFactoryValue_WhenTypeDoesNotMatch()
        {
            object input = "not a bool";
            bool result = input.AsOrDefault(obj => obj is string);
            Assert.True(result);
        }

        [Fact]
        public void AsOrDefault_NullInput_ReturnsDefault()
        {
            object input = null;
            int result = input.AsOrDefault<int>();
            Assert.Equal(default, result);
        }

        [Fact]
        public void AsOrDefault_WithFactory_NullInput_ReturnsFactoryValue()
        {
            object input = null;
            string result = input.AsOrDefault(() => "factory");
            Assert.Equal("factory", result);
        }
    }
}
