using System.Globalization;

namespace Aymadoka.Static.NullableNumberExtension
{
    public class NullableNumber_ToScientificNotationTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData(0f, "0.00E+00")]
        [InlineData(12345.6789f, "1.23E+04")]
        [InlineData(-0.00123f, "-1.23E-03")]
        public void Float_ToScientificNotation_DefaultDecimalPlaces(float? value, string expected)
        {
            var result = value.ToScientificNotation();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Float_ToScientificNotation_WithCulture()
        {
            float? value = 12345.6789f;
            var result = value.ToScientificNotation(3, new CultureInfo("fr-FR"));
            Assert.Equal("1,235E+04", result);
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(0d, "0.00E+00")]
        [InlineData(12345.6789d, "1.23E+04")]
        [InlineData(-0.00123d, "-1.23E-03")]
        public void Double_ToScientificNotation_DefaultDecimalPlaces(double? value, string expected)
        {
            var result = value.ToScientificNotation();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Double_ToScientificNotation_WithCulture()
        {
            double? value = 12345.6789d;
            var result = value.ToScientificNotation(4, new CultureInfo("de-DE"));
            Assert.Equal("1,2346E+04", result);
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(0.0, "0.00E+00")]
        [InlineData(12345.6789, "1.23E+04")]
        [InlineData(-0.00123, "-1.23E-03")]
        public void Decimal_ToScientificNotation_DefaultDecimalPlaces(decimal? value, string expected)
        {
            var result = value.ToScientificNotation();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Decimal_ToScientificNotation_WithCulture()
        {
            decimal? value = 12345.6789m;
            var result = value.ToScientificNotation(1, new CultureInfo("ru-RU"));
            Assert.Equal("1,2E+04", result);
        }
    }
}
