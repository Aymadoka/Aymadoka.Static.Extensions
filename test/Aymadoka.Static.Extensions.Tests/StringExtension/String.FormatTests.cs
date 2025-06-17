namespace Aymadoka.Static.StringExtension
{
    public class String_FormatTests
    {
        [Fact]
        public void Format_WithOneArgument_ReturnsFormattedString()
        {
            string format = "Hello, {0}!";
            string result = format.Format("World");
            Assert.Equal("Hello, World!", result);
        }

        [Fact]
        public void Format_WithTwoArguments_ReturnsFormattedString()
        {
            string format = "{0} + {1} = 3";
            string result = format.Format(1, 2);
            Assert.Equal("1 + 2 = 3", result);
        }

        [Fact]
        public void Format_WithThreeArguments_ReturnsFormattedString()
        {
            string format = "{0}, {1}, {2}";
            string result = format.Format("A", "B", "C");
            Assert.Equal("A, B, C", result);
        }

        [Fact]
        public void Format_WithArrayArguments_ReturnsFormattedString()
        {
            string format = "{0}-{1}-{2}";
            object[] args = { "X", "Y", "Z" };
            string result = format.Format(args);
            Assert.Equal("X-Y-Z", result);
        }

        [Fact]
        public void Format_WithNullFormat_ThrowsArgumentNullException()
        {
            string format = null;
            Assert.Throws<ArgumentNullException>(() => format.Format("test"));
        }

        [Fact]
        public void Format_WithNullArgsArray_ThrowsArgumentNullException()
        {
            string format = "{0}";
            object[] args = null;
            Assert.Throws<ArgumentNullException>(() => format.Format(args));
        }
    }
}
