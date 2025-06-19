namespace Aymadoka.Static.StringExtension
{
    public class String_RemoveDiacriticsTests
    {
        [Theory]
        [InlineData("café", "cafe")]
        [InlineData("naïve", "naive")]
        [InlineData("über", "uber")]
        [InlineData("façade", "facade")]
        [InlineData("résumé", "resume")]
        [InlineData("Ångström", "Angstrom")]
        [InlineData("Crème brûlée", "Creme brulee")]
        [InlineData("élève", "eleve")]
        [InlineData("Łódź", "Łodz")]
        [InlineData("São Paulo", "Sao Paulo")]
        [InlineData("中文", "中文")]
        [InlineData("", "")]
        public void RemoveDiacritics_ShouldRemoveDiacritics(string input, string expected)
        {
            Assert.Equal(expected, input.RemoveDiacritics());
        }

        [Fact]
        public void RemoveDiacritics_ShouldReturnNull_WhenInputIsNull()
        {
            string input = null;
            
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => StringExtensions.RemoveDiacritics(input));
        }
    }
}
