namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_GetPathRootTests
    {
        [Theory]
        [InlineData(@"C:\Temp\file.txt", @"C:\")]
        [InlineData(@"D:\folder\subfolder\file.doc", @"D:\")]
        [InlineData(@"\\server\share\folder\file.txt", @"\\server\share")]
        public void GetPathRoot_ReturnsExpectedRoot(string filePath, string expectedRoot)
        {
            var fileInfo = new FileInfo(filePath);
            var root = fileInfo.GetPathRoot();
            Assert.Equal(expectedRoot, root);
        }
    }
}
