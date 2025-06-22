using System.Text;

namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_ReadToEndTests : IDisposable
    {
        private readonly string _testFilePath;
        private readonly FileInfo _fileInfo;

        public FileInfo_ReadToEndTests()
        {
            _testFilePath = Path.GetTempFileName();
            _fileInfo = new FileInfo(_testFilePath);
        }

        [Fact]
        public void ReadToEnd_DefaultEncoding_ReadsAllText()
        {
            var content = "Hello, 世界!";
            File.WriteAllText(_testFilePath, content, Encoding.Default);

            var result = _fileInfo.ReadToEnd();

            Assert.Equal(content, result);
        }

        [Fact]
        public void ReadToEnd_WithPosition_ReadsFromPosition()
        {
            var content = "abcdefg";
            File.WriteAllText(_testFilePath, content, Encoding.Default);

            var result = _fileInfo.ReadToEnd(2);

            Assert.Equal("cdefg", result);
        }

        [Fact]
        public void ReadToEnd_WithEncoding_ReadsAllText()
        {
            var content = "你好, world!";
            File.WriteAllText(_testFilePath, content, Encoding.UTF8);

            var result = _fileInfo.ReadToEnd(Encoding.UTF8);

            Assert.Equal(content, result);
        }

        [Fact]
        public void ReadToEnd_WithEncodingAndPosition_ReadsFromPosition()
        {
            var content = "1234567890";
            File.WriteAllText(_testFilePath, content, Encoding.UTF8);

            // 读取从第4个字节（"5"）开始的内容
            var result = _fileInfo.ReadToEnd(Encoding.UTF8, 4);

            // "12"占4字节，剩下"234567890"
            Assert.Equal("234567890", result);
        }

        public void Dispose()
        {
            if (File.Exists(_testFilePath))
                File.Delete(_testFilePath);
        }
    }
}
