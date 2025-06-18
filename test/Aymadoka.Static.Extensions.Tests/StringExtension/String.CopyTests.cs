namespace Aymadoka.Static.StringExtension
{
    public class String_CopyTests
    {
        [Fact]
        public void Copy_NullString_ReturnsNull()
        {
            string? input = null;
            var result = input.Copy();
            Assert.Null(result);
        }

        [Fact]
        public void Copy_EmptyString_ReturnsNewEmptyString()
        {
            string input = string.Empty;
            var result = input.Copy();
            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Copy_NormalString_ReturnsNewStringWithSameContent()
        {
            string input = "Hello, world!";
            var result = input.Copy();
            Assert.NotNull(result);
            Assert.Equal(input, result);
            Assert.False(object.ReferenceEquals(input, result));
        }

        [Fact]
        public void Copy_UnicodeString_ReturnsNewStringWithSameContent()
        {
            string input = "你好，世界！";
            var result = input.Copy();
            Assert.NotNull(result);
            Assert.Equal(input, result);
            Assert.False(object.ReferenceEquals(input, result));
        }
    }
}
