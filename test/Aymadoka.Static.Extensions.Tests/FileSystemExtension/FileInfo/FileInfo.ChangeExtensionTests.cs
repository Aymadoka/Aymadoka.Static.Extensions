namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_ChangeExtensionTests
    {
        [Theory]
        [InlineData("test.txt", ".md", "test.md")]
        [InlineData("archive.tar.gz", ".zip", "archive.tar.zip")]
        [InlineData("noext", ".log", "noext.log")]
        [InlineData("sample.doc", "pdf", "sample.pdf")]
        [InlineData("file.old", null, "file")]
        public void ChangeExtension_ShouldReturnExpectedPath(string originalName, string newExtension, string expectedName)
        {
            // Arrange
            var tempDir = Path.GetTempPath();
            var originalPath = Path.Combine(tempDir, originalName);
            var fileInfo = new FileInfo(originalPath);

            // Act
            var result = fileInfo.ChangeExtension(newExtension);

            // Assert
            var expectedPath = Path.Combine(tempDir, expectedName);
            Assert.Equal(expectedPath, result);
        }
    }
}
