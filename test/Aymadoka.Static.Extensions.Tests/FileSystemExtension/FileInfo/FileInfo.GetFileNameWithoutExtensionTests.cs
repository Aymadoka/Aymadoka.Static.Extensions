namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_GetFileNameWithoutExtensionTests
    {
        [Theory]
        [InlineData(@"C:\Temp\test.txt", "test")]
        [InlineData(@"C:\Temp\archive.tar.gz", "archive.tar")]
        [InlineData(@"C:\Temp\.hiddenfile", "")]
        [InlineData(@"C:\Temp\noextension", "noextension")]
        [InlineData(@"test.txt", "test")]
        [InlineData(@".env", "")]
        public void GetFileNameWithoutExtension_ReturnsExpectedResult(string filePath, string expected)
        {
            var fileInfo = new FileInfo(filePath);
            var result = fileInfo.GetFileNameWithoutExtension();
            Assert.Equal(expected, result);
        }
    }
}
