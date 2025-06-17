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
        [InlineData("Łódź", "Lodz")]
        [InlineData("São Paulo", "Sao Paulo")]
        [InlineData("中文", "中文")]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void RemoveDiacritics_ShouldRemoveDiacritics(string input, string expected)
        {
            if (input == null)
            {
                Assert.Null(StringExtensions.RemoveDiacritics(input));
            }
            else
            {
                Assert.Equal(expected, input.RemoveDiacritics());
            }
        }
    }
}
