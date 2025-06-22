namespace Aymadoka.Static.StringExtension
{
    public class String_FormatWithTests
    {
        [Fact]
        public void FormatWith_OneArgument_ShouldFormatCorrectly()
        {
            string format = "Hello, {0}!";
            string result = format.FormatWith("World");
            Assert.Equal("Hello, World!", result);
        }

        [Fact]
        public void FormatWith_TwoArguments_ShouldFormatCorrectly()
        {
            string format = "{0} + {1} = 3";
            string result = format.FormatWith(1, 2);
            Assert.Equal("1 + 2 = 3", result);
        }

        [Fact]
        public void FormatWith_ThreeArguments_ShouldFormatCorrectly()
        {
            string format = "{0}, {1}, {2}";
            string result = format.FormatWith("A", "B", "C");
            Assert.Equal("A, B, C", result);
        }

        [Fact]
        public void FormatWith_ParamsArguments_ShouldFormatCorrectly()
        {
            string format = "{0}-{1}-{2}-{3}";
            string result = format.FormatWith(1, 2, 3, 4);
            Assert.Equal("1-2-3-4", result);
        }

        [Fact]
        public void FormatWith_NullFormat_ShouldThrow()
        {
            string format = null;
            Assert.Throws<ArgumentNullException>(() => format.FormatWith("test"));
        }

        [Fact]
        public void FormatWith_NullArguments_ShouldFormatAsEmpty()
        {
            string format = "{0}";
            string result = format.FormatWith((object)null);
            Assert.Equal(string.Format("{0}", (object)null), result);
        }
    }
}
