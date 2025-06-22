namespace Aymadoka.Static.DirectoryInfoExtension
{
    public class DirectoryInfo_GetSizeTests
    {
        [Fact]
        public void GetSize_ReturnsZero_ForEmptyDirectory()
        {
            var tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
            tempDir.Create();
            try
            {
                long size = tempDir.GetSize();
                Assert.Equal(0, size);
            }
            finally
            {
                tempDir.Delete(true);
            }
        }

        [Fact]
        public void GetSize_ReturnsSumOfFileSizes()
        {
            var tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
            tempDir.Create();
            try
            {
                var file1 = Path.Combine(tempDir.FullName, "file1.txt");
                var file2 = Path.Combine(tempDir.FullName, "file2.txt");
                File.WriteAllBytes(file1, new byte[100]);
                File.WriteAllBytes(file2, new byte[200]);

                long size = tempDir.GetSize();
                Assert.Equal(300, size);
            }
            finally
            {
                tempDir.Delete(true);
            }
        }

        [Fact]
        public void GetSize_IncludesSubdirectoryFiles()
        {
            var tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
            tempDir.Create();
            try
            {
                var subDir = tempDir.CreateSubdirectory("sub");
                var file1 = Path.Combine(tempDir.FullName, "file1.txt");
                var file2 = Path.Combine(subDir.FullName, "file2.txt");
                File.WriteAllBytes(file1, new byte[50]);
                File.WriteAllBytes(file2, new byte[150]);

                long size = tempDir.GetSize();
                Assert.Equal(200, size);
            }
            finally
            {
                tempDir.Delete(true);
            }
        }
    }
}
