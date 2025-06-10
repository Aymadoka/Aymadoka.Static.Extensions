using System.Text;

namespace Aymadoka.Static.HashExtension
{
    public class Hash_ToSHA256HashTests
    {
        [Theory]
        [InlineData("hello", "2cf24dba5fb0a30e26e83b2ac5b9e29e1b161e5c1fa7425e73043362938b9824")]
        [InlineData("", "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855")]
        public void ToSHA256Hash_String_DefaultFormat(string input, string expected)
        {
            var hash = input.ToSHA256Hash();
            Assert.Equal(expected, hash);
        }

        [Fact]
        public void ToSHA256Hash_String_WithSalt()
        {
            string input = "hello";
            string salt = "salt";
            var hash = input.ToSHA256Hash(salt);
            // 预期值由实际实现决定
            var expected = Encoding.UTF8.GetBytes(input).ToSHA256Hash(salt, EnumHashFormat.x2);
            Assert.Equal(expected, hash);
        }

        [Theory]
        [InlineData("hello", EnumHashFormat.x2, "2cf24dba5fb0a30e26e83b2ac5b9e29e1b161e5c1fa7425e73043362938b9824")]
        [InlineData("hello", EnumHashFormat.X2, "2CF24DBA5FB0A30E26E83B2AC5B9E29E1B161E5C1FA7425E73043362938B9824")]
        public void ToSHA256Hash_String_Format(string input, EnumHashFormat format, string expected)
        {
            var hash = input.ToSHA256Hash(format);
            Assert.Equal(expected, hash);
        }

        [Fact]
        public void ToSHA256Hash_ByteArray_DefaultFormat()
        {
            byte[] input = Encoding.UTF8.GetBytes("hello");
            var hash = input.ToSHA256Hash();
            Assert.Equal("2cf24dba5fb0a30e26e83b2ac5b9e29e1b161e5c1fa7425e73043362938b9824", hash);
        }

        [Fact]
        public void ToSHA256Hash_ByteArray_WithSalt()
        {
            byte[] input = Encoding.UTF8.GetBytes("hello");
            string salt = "salt";
            var hash = input.ToSHA256Hash(salt);
            var expected = input.ToSHA256Hash(salt, EnumHashFormat.x2);
            Assert.Equal(expected, hash);
        }

        [Fact]
        public void ToSHA256Hash_ByteArray_Format()
        {
            byte[] input = Encoding.UTF8.GetBytes("hello");
            var hash = input.ToSHA256Hash(EnumHashFormat.X2);
            Assert.Equal("2CF24DBA5FB0A30E26E83B2AC5B9E29E1B161E5C1FA7425E73043362938B9824", hash);
        }

        [Fact]
        public void ToSHA256Hash_String_Null_Throws()
        {
            string input = null;
            Assert.Throws<ArgumentNullException>(() => input.ToSHA256Hash());
        }

        [Fact]
        public void ToSHA256Hash_ByteArray_Null_Throws()
        {
            byte[] input = null;
            Assert.Throws<ArgumentNullException>(() => input.ToSHA256Hash());
        }
    }
}
