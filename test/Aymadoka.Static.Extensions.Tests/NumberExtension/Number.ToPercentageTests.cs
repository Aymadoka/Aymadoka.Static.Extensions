using System.Globalization;

namespace Aymadoka.Static.NumberExtension
{
    public class Number_ToPercentageTests
    {
        [Theory]
        [InlineData(0.1234f, 2, "12.34%")]
        [InlineData(0.1f, 0, "10%")]
        [InlineData(1.0f, 1, "100.0%")]
        [InlineData(0f, 3, "0.000%")]
        [InlineData(-0.5f, 1, "-50.0%")]
        public void Float_ToPercentage_DefaultCulture(float value, int places, string expected)
        {
            var result = value.ToPercentage(places);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0.1234, 2, "12.34%")]
        [InlineData(0.1, 0, "10%")]
        [InlineData(1.0, 1, "100.0%")]
        [InlineData(0d, 3, "0.000%")]
        [InlineData(-0.5, 1, "-50.0%")]
        public void Double_ToPercentage_DefaultCulture(double value, int places, string expected)
        {
            var result = value.ToPercentage(places);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0.1234, 2, "12,34%")]
        [InlineData(0.1, 0, "10%")]
        [InlineData(1.0, 1, "100,0%")]
        [InlineData(0d, 3, "0,000%")]
        [InlineData(-0.5, 1, "-50,0%")]
        public void Double_ToPercentage_CustomCulture(double value, int places, string expected)
        {
            var culture = new CultureInfo("fr-FR");
            var result = value.ToPercentage(places, culture);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0.1234, 2, "12.34%")]
        [InlineData(0.1, 0, "10%")]
        [InlineData(1.0, 1, "100.0%")]
        [InlineData(0d, 3, "0.000%")]
        [InlineData(-0.5, 1, "-50.0%")]
        public void Decimal_ToPercentage_DefaultCulture(decimal value, int places, string expected)
        {
            var result = value.ToPercentage(places);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0.1234, 2, "12,34%")]
        [InlineData(0.1, 0, "10%")]
        [InlineData(1.0, 1, "100,0%")]
        [InlineData(0d, 3, "0,000%")]
        [InlineData(-0.5, 1, "-50,0%")]
        public void Decimal_ToPercentage_CustomCulture(decimal value, int places, string expected)
        {
            var culture = new CultureInfo("fr-FR");
            var result = value.ToPercentage(places, culture);
            Assert.Equal(expected, result);
        }
    }
}
