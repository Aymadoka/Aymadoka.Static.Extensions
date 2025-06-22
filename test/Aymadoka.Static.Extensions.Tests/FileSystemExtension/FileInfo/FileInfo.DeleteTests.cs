namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_DeleteTests
    {
        [Fact]
        public void Delete_ShouldDeleteAllFilesInCollection()
        {
            // Arrange
            var tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDir);
            var filePaths = new List<string>
            {
                Path.Combine(tempDir, "file1.txt"),
                Path.Combine(tempDir, "file2.txt"),
                Path.Combine(tempDir, "file3.txt")
            };
            foreach (var path in filePaths)
            {
                File.WriteAllText(path, "test");
            }
            var fileInfos = filePaths.Select(p => new FileInfo(p)).ToList();

            // Act
            fileInfos.Delete();

            // Assert
            foreach (var path in filePaths)
            {
                Assert.False(System.IO.File.Exists(path));
            }

            // Cleanup
            Directory.Delete(tempDir, true);
        }
    }
}
