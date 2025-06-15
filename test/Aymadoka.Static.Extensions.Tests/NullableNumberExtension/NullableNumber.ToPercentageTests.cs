using System.Globalization;

namespace Aymadoka.Static.NullableNumberExtension
{
    public class NullableNumber_ToPercentageTests
    {
        [Theory]
        [InlineData(null, 2, null)]
        [InlineData(0.1234f, 2, "12.34%")]
        [InlineData(0f, 0, "0%")]
        [InlineData(1f, 1, "100.0%")]
        public void ToPercentage_Float_ReturnsExpected(float? value, int places, string expected)
        {
            var result = value.ToPercentage(places);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(null, 2, null)]
        [InlineData(0.5678f, 1, "56,8 %")]
        public void ToPercentage_Float_WithCulture_ReturnsExpected(float? value, int places, string expected)
        {
            var culture = new CultureInfo("fr-FR");
            var result = value.ToPercentage(places, culture);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(null, 2, null)]
        [InlineData(0.123456, 3, "12.346%")]
        [InlineData(1.0, 0, "100%")]
        public void ToPercentage_Double_ReturnsExpected(double? value, int places, string expected)
        {
            var result = value.ToPercentage(places);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(null, 2, null)]
        [InlineData(0.5, 1, "50,0 %")]
        public void ToPercentage_Double_WithCulture_ReturnsExpected(double? value, int places, string expected)
        {
            var culture = new CultureInfo("fr-FR");
            var result = value.ToPercentage(places, culture);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(null, 2, null)]
        [InlineData(0.3333, 2, "33.33%")]
        [InlineData(1.0, 0, "100%")]
        public void ToPercentage_Decimal_ReturnsExpected(decimal? value, int places, string expected)
        {
            var result = value.ToPercentage(places);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(null, 2, null)]
        [InlineData(0.25, 2, "25,00 %")]
        public void ToPercentage_Decimal_WithCulture_ReturnsExpected(decimal? value, int places, string expected)
        {
            var culture = new CultureInfo("fr-FR");
            var result = value.ToPercentage(places, culture);
            Assert.Equal(expected, result);
        }
    }
}
