namespace Aymadoka.Static.ObjectExtension
{
    public class Object_CoalesceOrDefaultTests
    {
        [Fact]
        public void CoalesceOrDefault_ReturnsThis_WhenNotNull()
        {
            string value = "abc";
            string result = value.CoalesceOrDefault("def", "ghi");
            Assert.Equal("abc", result);
        }

        [Fact]
        public void CoalesceOrDefault_ReturnsFirstNonNullValue_WhenThisIsNull()
        {
            string value = null;
            string[] values = { null, "def", "ghi" };
            string result = value.CoalesceOrDefault(values);
            Assert.Equal("def", result);
        }

        [Fact]
        public void CoalesceOrDefault_ReturnsDefault_WhenAllAreNull()
        {
            string value = null;
            string[] values = { null, null };
            string result = value.CoalesceOrDefault(values);
            Assert.Null(result);
        }

        [Fact]
        public void CoalesceOrDefault_WithFactory_ReturnsThis_WhenNotNull()
        {
            string value = "abc";
            string result = value.CoalesceOrDefault(() => "default", "def", "ghi");
            Assert.Equal("abc", result);
        }

        [Fact]
        public void CoalesceOrDefault_WithFactory_ReturnsFirstNonNull_WhenThisIsNull()
        {
            string value = null;
            string result = value.CoalesceOrDefault(() => "default", null, "def", "ghi");
            Assert.Equal("def", result);
        }

        [Fact]
        public void CoalesceOrDefault_WithFactory_ReturnsFactory_WhenAllNull()
        {
            string value = null;
            string result = value.CoalesceOrDefault(() => "default", null, null);
            Assert.Equal("default", result);
        }

        [Fact]
        public void CoalesceOrDefault_WithFactoryArg_ReturnsThis_WhenNotNull()
        {
            string value = "abc";
            string result = value.CoalesceOrDefault(v => "default", "def", "ghi");
            Assert.Equal("abc", result);
        }

        [Fact]
        public void CoalesceOrDefault_WithFactoryArg_ReturnsFirstNonNull_WhenThisIsNull()
        {
            string value = null;
            string result = value.CoalesceOrDefault(v => "default", null, "def", "ghi");
            Assert.Equal("def", result);
        }

        [Fact]
        public void CoalesceOrDefault_WithFactoryArg_ReturnsFactory_WhenAllNull()
        {
            string value = null;
            string result = value.CoalesceOrDefault(v => v ?? "default", null, null);
            Assert.Equal("default", result);
        }
    }
}
