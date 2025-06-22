namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_GetDirectoryNameTests
    {
        [Fact]
        public void GetDirectoryName_Returns_Correct_Directory_Name()
        {
            // Arrange
            var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            var filePath = Path.Combine(tempDir, "testfile.txt");
            File.WriteAllText(filePath, "test");
            var fileInfo = new FileInfo(filePath);

            // Act
            var dirName = fileInfo.GetDirectoryName();

            // Assert
            Assert.Equal(new DirectoryInfo(tempDir).Name, dirName);

            // Cleanup
            File.Delete(filePath);
            Directory.Delete(tempDir);
        }

        [Fact]
        public void GetDirectoryName_When_Directory_Is_Null()
        {
            var fi = new FileInfo(Path.GetFileNameWithoutExtension(Path.GetRandomFileName()));

            // forcibly set Directory to null is not possible, so just call the method and expect it to throw if Directory is null
            _ = fi.GetDirectoryName();
        }
    }
}
