using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Aymadoka.Static.NullableNumberExtension
{
    public class NullableNumber_ToScientificNotationTests
    {
        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> FloatToScientificNotationDefaultDecimalPlacesData()
        {
            yield return new object[] { null, null };
            yield return new object[] { (float?)0f, "0.00E+000" };
            yield return new object[] { (float?)12345.6789f, "1.23E+004" };
            yield return new object[] { (float?)-0.00123f, "-1.23E-003" };
        }

        [Theory]
        [MemberData(nameof(FloatToScientificNotationDefaultDecimalPlacesData))]
        public void Float_ToScientificNotation_DefaultDecimalPlaces(float? value, string expected)
        {
            var result = value.ToScientificNotation();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Float_ToScientificNotation_WithCulture_NullValue()
        {
            float? value = null;
            var result = value.ToScientificNotation(3, new CultureInfo("fr-FR"));
            Assert.Null(result);
        }

        [Fact]
        public void Float_ToScientificNotation_WithCulture_NotNullValue()
        {
            float? value = 10;
            var result = value.ToScientificNotation(3, new CultureInfo("fr-FR"));
            Assert.NotNull(result);
            Assert.Equal("1,000E+001", result);
        }


        [Fact]
        public void Double_ToScientificNotation_WithCulture_NullValue()
        {
            double? value = null;
            var result = value.ToScientificNotation(4, new CultureInfo("de-DE"));
            Assert.Null(result);
        }

        [Fact]
        public void Decimal_ToScientificNotation_WithCulture_NullValue()
        {
            decimal? value = null;
            var result = value.ToScientificNotation(1, new CultureInfo("ru-RU"));
            Assert.Null(result);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> DoubleToScientificNotationDefaultDecimalPlacesData()
        {
            yield return new object[] { null, null };
            yield return new object[] { (double?)0d, "0.00E+000" };
            yield return new object[] { (double?)12345.6789d, "1.23E+004" };
            yield return new object[] { (double?)-0.00123d, "-1.23E-003" };
        }

        [Theory]
        [MemberData(nameof(DoubleToScientificNotationDefaultDecimalPlacesData))]
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
            Assert.Equal("1,2346E+004", result);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> DecimalToScientificNotationDefaultDecimalPlacesData()
        {
            yield return new object[] { null, null };
            yield return new object[] { (decimal?)0.0, "0.00E+000" };
            yield return new object[] { (decimal?)12345.6789d, "1.23E+004" };
            yield return new object[] { (decimal?)-0.00123d, "-1.23E-003" };
        }

        [Theory]
        [MemberData(nameof(DecimalToScientificNotationDefaultDecimalPlacesData))]
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
            Assert.Equal("1,2E+004", result);
        }
    }
}
