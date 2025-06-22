using System.Globalization;

namespace Aymadoka.Static.NumberExtension
{
    public class Number_ToScientificNotationTests
    {
        [Theory]
        [InlineData(12345.6789f, 2, "1.23E+004")]
        [InlineData(0.0001234f, 3, "1.234E-004")]
        [InlineData(-98765.4321f, 1, "-9.9E+004")]
        public void ToScientificNotation_Float_DefaultCulture(float value, int decimalPlaces, string expected)
        {
            var result = value.ToScientificNotation(decimalPlaces);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(12345.6789, 2, "1.23E+004")]
        [InlineData(0.0001234, 3, "1.234E-004")]
        [InlineData(-98765.4321, 1, "-9.9E+004")]
        public void ToScientificNotation_Double_DefaultCulture(double value, int decimalPlaces, string expected)
        {
            var result = value.ToScientificNotation(decimalPlaces);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(12345.6789, 2, "1,23E+004")]
        [InlineData(0.0001234, 3, "1,234E-004")]
        public void ToScientificNotation_Double_SpecificCulture(double value, int decimalPlaces, string expected)
        {
            var culture = new CultureInfo("fr-FR");
            var result = value.ToScientificNotation(decimalPlaces, culture);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(12345.6789, 2, "1.23E+004")]
        [InlineData(0.0001234, 3, "1.234E-004")]
        [InlineData(-98765.4321, 1, "-9.9E+004")]
        public void ToScientificNotation_Decimal_DefaultCulture(decimal value, int decimalPlaces, string expected)
        {
            var result = value.ToScientificNotation(decimalPlaces);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToScientificNotation_Decimal_SpecificCulture()
        {
            decimal value = 12345.6789m;
            var culture = new CultureInfo("de-DE");
            var result = value.ToScientificNotation(2, culture);
            Assert.Equal("1,23E+004", result);
        }
    }
}
