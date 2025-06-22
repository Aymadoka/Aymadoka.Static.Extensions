using System.Text;

namespace Aymadoka.Static.StreamExtension
{
    public class Stream_ReadToEndTests
    {
        [Fact]
        public void ReadToEnd_DefaultEncoding_ReadsAllText()
        {
            var text = "Hello, 世界!";
            using var ms = new MemoryStream(Encoding.Default.GetBytes(text));
            var result = ms.ReadToEnd();
            Assert.Equal(text, result);
        }

        [Fact]
        public void ReadToEnd_SpecifiedEncoding_ReadsAllText()
        {
            var text = "Hello, 世界!";
            using var ms = new MemoryStream(Encoding.UTF8.GetBytes(text));
            var result = ms.ReadToEnd(Encoding.UTF8);
            Assert.Equal(text, result);
        }

        [Fact]
        public void ReadToEnd_FromPosition_DefaultEncoding_ReadsPartialText()
        {
            var text = "Hello, 世界!";
            var bytes = Encoding.Default.GetBytes(text);
            using var ms = new MemoryStream(bytes);
            var position = Encoding.Default.GetByteCount("Hello, ");
            var result = ms.ReadToEnd(position);
            Assert.Equal("世界!", result);
        }

        [Fact]
        public void ReadToEnd_FromPosition_SpecifiedEncoding_ReadsPartialText()
        {
            var text = "Hello, 世界!";
            var bytes = Encoding.UTF8.GetBytes(text);
            using var ms = new MemoryStream(bytes);
            var position = Encoding.UTF8.GetByteCount("Hello, ");
            var result = ms.ReadToEnd(Encoding.UTF8, position);
            Assert.Equal("世界!", result);
        }

        [Fact]
        public void ReadToEnd_EmptyStream_ReturnsEmptyString()
        {
            using var ms = new MemoryStream();
            var result = ms.ReadToEnd();
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void ReadToEnd_PositionBeyondLength_ReturnsEmptyString()
        {
            var text = "abc";
            using var ms = new MemoryStream(Encoding.UTF8.GetBytes(text));
            var result = ms.ReadToEnd(Encoding.UTF8, 100);
            Assert.Equal(string.Empty, result);
        }
    }
}
