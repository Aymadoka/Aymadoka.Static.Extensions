namespace Aymadoka.Static.ObjectExtension
{
    public class Object_GetValueOrDefaultTests
    {
        [Fact]
        public void GetValueOrDefault_ReturnsValue_WhenNoException()
        {
            int source = 5;
            int result = source.GetValueOrDefault(x => x * 2);
            Assert.Equal(10, result);
        }

        [Fact]
        public void GetValueOrDefault_ReturnsDefault_WhenException()
        {
            string source = null;
            int result = source.GetValueOrDefault(s => s.Length);
            Assert.Equal(0, result);
        }

        [Fact]
        public void GetValueOrDefault_WithDefaultValue_ReturnsValue_WhenNoException()
        {
            int source = 3;
            int result = source.GetValueOrDefault(x => x + 1, 99);
            Assert.Equal(4, result);
        }

        [Fact]
        public void GetValueOrDefault_WithDefaultValue_ReturnsDefault_WhenException()
        {
            string source = null;
            int result = source.GetValueOrDefault(s => s.Length, 42);
            Assert.Equal(42, result);
        }

        [Fact]
        public void GetValueOrDefault_WithDefaultValueFactory_ReturnsValue_WhenNoException()
        {
            int source = 7;
            int result = source.GetValueOrDefault(x => x * 3, () => 100);
            Assert.Equal(21, result);
        }

        [Fact]
        public void GetValueOrDefault_WithDefaultValueFactory_ReturnsFactoryValue_WhenException()
        {
            string source = null;
            int result = source.GetValueOrDefault(s => s.Length, () => 123);
            Assert.Equal(123, result);
        }

        [Fact]
        public void GetValueOrDefault_WithDefaultValueFactoryT_ReturnsValue_WhenNoException()
        {
            int source = 2;
            int result = source.GetValueOrDefault(x => x * 5, x => x + 10);
            Assert.Equal(10, result);
        }

        [Fact]
        public void GetValueOrDefault_WithDefaultValueFactoryT_ReturnsFactoryValue_WhenException()
        {
            string source = null;
            int result = source.GetValueOrDefault(s => s.Length, s => s == null ? -1 : 0);
            Assert.Equal(-1, result);
        }
    }
}
