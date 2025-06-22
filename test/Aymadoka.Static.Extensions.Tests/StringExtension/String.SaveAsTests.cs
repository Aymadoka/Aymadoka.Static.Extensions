namespace Aymadoka.Static.StringExtension
{
    public class String_SaveAsTests
    {
        private readonly string _testFilePath;

        public String_SaveAsTests()
        {
            _testFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".txt");
        }

        [Fact]
        public void SaveAs_String_FileName_Overwrite()
        {
            string content = "Hello, World!";
            content.SaveAs(_testFilePath);
            string result = File.ReadAllText(_testFilePath);
            Assert.Equal(content, result);
        }

        [Fact]
        public void SaveAs_String_FileName_Append()
        {
            string content1 = "Line1";
            string content2 = "Line2";
            content1.SaveAs(_testFilePath);
            content2.SaveAs(_testFilePath, append: true);
            string result = File.ReadAllText(_testFilePath);
            Assert.Equal(content1 + content2, result);
        }

        [Fact]
        public void SaveAs_String_FileInfo_Overwrite()
        {
            string content = "FileInfo Test";
            var fileInfo = new FileInfo(_testFilePath);
            content.SaveAs(fileInfo);
            string result = File.ReadAllText(_testFilePath);
            Assert.Equal(content, result);
        }

        [Fact]
        public void SaveAs_String_FileInfo_Append()
        {
            string content1 = "A";
            string content2 = "B";
            var fileInfo = new FileInfo(_testFilePath);
            content1.SaveAs(fileInfo);
            content2.SaveAs(fileInfo, append: true);
            string result = File.ReadAllText(_testFilePath);
            Assert.Equal(content1 + content2, result);
        }

        public void Dispose()
        {
            if (File.Exists(_testFilePath))
            {
                File.Delete(_testFilePath);
            }
        }
    }
}
