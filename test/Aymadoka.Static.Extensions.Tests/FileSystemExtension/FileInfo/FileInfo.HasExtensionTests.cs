namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_HasExtensionTests
    {
        [Theory]
        [InlineData("test.txt", true)]
        [InlineData("archive.tar.gz", true)]
        [InlineData("noextension", false)]
        [InlineData(".hiddenfile", true)]
        [InlineData("file.", false)]
        public void HasExtension_ReturnsExpectedResult(string fileName, bool expected)
        {
            var fileInfo = new FileInfo(fileName);
            var result = fileInfo.HasExtension();
            Assert.Equal(expected, result);
        }
    }
}
