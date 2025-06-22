namespace Aymadoka.Static.FileInfoExtension
{
    public class FileInfo_GetDirectoryFullNameTests
    {
        [Fact]
        public void GetDirectoryFullName_Returns_Correct_Directory()
        {
            // Arrange
            var tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDir);
            var tempFile = Path.Combine(tempDir, "testfile.txt");
            File.WriteAllText(tempFile, "test");
            var fileInfo = new FileInfo(tempFile);

            // Act
            var dirFullName = fileInfo.GetDirectoryFullName();

            // Assert
            Assert.Equal(tempDir, dirFullName);

            // Cleanup
            File.Delete(tempFile);
            Directory.Delete(tempDir);
        }

        [Fact]
        public void GetDirectoryFullName_Throws_On_Null_FileInfo()
        {
            // Arrange
            FileInfo fileInfo = null;

            // Act & Assert
            Assert.Throws<System.NullReferenceException>(() => fileInfo.GetDirectoryFullName());
        }
    }
}
