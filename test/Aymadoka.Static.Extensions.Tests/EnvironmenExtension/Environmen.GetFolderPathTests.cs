namespace Aymadoka.Static.EnvironmenExtension
{
    public class Environmen_GetFolderPathTests
    {
        [Theory]
        [InlineData(Environment.SpecialFolder.Desktop)]
        [InlineData(Environment.SpecialFolder.MyDocuments)]
        [InlineData(Environment.SpecialFolder.ApplicationData)]
        public void GetFolderPath_ShouldReturnValidPath(Environment.SpecialFolder folder)
        {
            var path = folder.GetFolderPath();
            Assert.False(string.IsNullOrWhiteSpace(path));
        }

        [Theory]
        [InlineData(Environment.SpecialFolder.Desktop, Environment.SpecialFolderOption.None)]
        [InlineData(Environment.SpecialFolder.MyDocuments, Environment.SpecialFolderOption.Create)]
        [InlineData(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.DoNotVerify)]
        public void GetFolderPath_WithOption_ShouldReturnValidPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
        {
            var path = folder.GetFolderPath(option);
            Assert.False(string.IsNullOrWhiteSpace(path));
        }
    }
}
