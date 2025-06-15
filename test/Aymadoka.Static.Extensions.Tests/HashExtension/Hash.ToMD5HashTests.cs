using System.Text;

namespace Aymadoka.Static.HashExtension
{
    public class Hash_ToMD5HashTests
    {
        [Theory]
        [InlineData("hello", "5d41402abc4b2a76b9719d911017c592")]
        [InlineData("", "d41d8cd98f00b204e9800998ecf8427e")]
        public void ToMD5Hash_String_DefaultFormat(string input, string expected)
        {
            var hash = input.ToMD5Hash();
            Assert.Equal(expected, hash);
        }

        [Theory]
        [InlineData("hello", "salt", "06decc8b095724f80103712c235586be")]
        [InlineData("", "salt", "ceb20772e0c9d240c75eb26b0e37abee")]
        public void ToMD5Hash_String_WithSalt(string input, string salt, string expected)
        {
            var hash = input.ToMD5Hash(salt);
            Assert.Equal(expected, hash);
        }

        [Theory]
        [InlineData("hello", EnumHashFormat.x2, "5d41402abc4b2a76b9719d911017c592")]
        [InlineData("hello", EnumHashFormat.X2, "5D41402ABC4B2A76B9719D911017C592")]
        [InlineData("hello", EnumHashFormat.x, "5d41402abc4b2a76b9719d911017c592")]
        [InlineData("hello", EnumHashFormat.X, "5D41402ABC4B2A76B9719D911017C592")]
        public void ToMD5Hash_String_WithFormat(string input, EnumHashFormat format, string expected)
        {
            var hash = input.ToMD5Hash(format);
            if (format == EnumHashFormat.x2 || format == EnumHashFormat.x)
                Assert.Equal(expected.ToLower(), hash.ToLower());
            else
                Assert.Equal(expected.ToUpper(), hash.ToUpper());
        }

        [Fact]
        public void ToMD5Hash_String_WithSaltAndFormat()
        {
            var input = "hello";
            var salt = "salt";
            var hash = input.ToMD5Hash(salt, EnumHashFormat.X2);
            Assert.Equal("06DECC8B095724F80103712C235586BE", hash);
        }

        [Fact]
        public void ToMD5Hash_ByteArray_DefaultFormat()
        {
            var bytes = Encoding.UTF8.GetBytes("hello");
            var hash = bytes.ToMD5Hash();
            Assert.Equal("5d41402abc4b2a76b9719d911017c592", hash);
        }

        [Fact]
        public void ToMD5Hash_ByteArray_WithSalt()
        {
            var bytes = Encoding.UTF8.GetBytes("hello");
            var hash = bytes.ToMD5Hash("salt");
            Assert.Equal("06decc8b095724f80103712c235586be", hash);
        }

        [Fact]
        public void ToMD5Hash_ByteArray_WithFormat()
        {
            var bytes = Encoding.UTF8.GetBytes("hello");
            var hash = bytes.ToMD5Hash(EnumHashFormat.X2);
            Assert.Equal("5D41402ABC4B2A76B9719D911017C592", hash);
        }

        [Fact]
        public void ToMD5Hash_ByteArray_WithSaltAndFormat()
        {
            var bytes = Encoding.UTF8.GetBytes("hello");
            var hash = bytes.ToMD5Hash("salt", EnumHashFormat.X2);
            Assert.Equal("06DECC8B095724F80103712C235586BE", hash);
        }

        [Fact]
        public void ToMD5Hash_String_Null_Throws()
        {
            string input = null;
            Assert.Throws<ArgumentNullException>(() => input.ToMD5Hash());
        }

        [Fact]
        public void ToMD5Hash_ByteArray_Null_Throws()
        {
            byte[] input = null;
            Assert.Throws<ArgumentNullException>(() => input.ToMD5Hash());
        }
    }
}
