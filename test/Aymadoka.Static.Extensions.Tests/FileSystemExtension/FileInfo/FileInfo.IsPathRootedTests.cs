namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_IsPathRootedTests
    {
        [Theory]
        [InlineData(@"C:\", true)]
        [InlineData(@"C:\test.txt", true)]
        [InlineData(@"\test.txt", true)]
        [InlineData(@"test.txt", true)]
        [InlineData(@"..\test.txt", true)]
        public void IsPathRooted_ReturnsExpectedResult(string path, bool expected)
        {
            var fileInfo = new FileInfo(path);
            var result = fileInfo.IsPathRooted();
            Assert.Equal(expected, result);
        }
    }
}
