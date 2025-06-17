namespace Aymadoka.Static.StringExtension
{
    public class String_PathCombineTests
    {
        [Fact]
        public void PathCombine_WithSinglePath_ReturnsCombinedPath()
        {
            string basePath = "folder";
            string result = basePath.PathCombine("subfolder");
            Assert.Equal(System.IO.Path.Combine("folder", "subfolder"), result);
        }

        [Fact]
        public void PathCombine_WithMultiplePaths_ReturnsCombinedPath()
        {
            string basePath = "folder";
            string result = basePath.PathCombine("subfolder", "file.txt");
            Assert.Equal(System.IO.Path.Combine("folder", "subfolder", "file.txt"), result);
        }

        [Fact]
        public void PathCombine_WithNoAdditionalPaths_ReturnsBasePath()
        {
            string basePath = "folder";
            string result = basePath.PathCombine();
            Assert.Equal("folder", result);
        }

        [Fact]
        public void PathCombine_WithNullBasePath_ThrowsArgumentNullException()
        {
            string basePath = null;
            Assert.Throws<ArgumentNullException>(() => basePath.PathCombine("subfolder"));
        }

        [Fact]
        public void PathCombine_WithNullInPaths_ThrowsArgumentNullException()
        {
            string basePath = "folder";
            Assert.Throws<ArgumentNullException>(() => basePath.PathCombine(null));
        }
    }
}
