using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NullableNumberExtension
{
    public class NullableNumber_KeepTests
    {
        [Theory]
        [InlineData(null, 2, null)]
        [InlineData(1.2345f, 2, 1.23f)]
        [InlineData(1.2355f, 2, 1.24f)]
        [InlineData(-1.236f, 2, -1.24f)]
        public void ToKeep_FloatNullable_Works(float? value, int keep, float? expected)
        {
            // Arrange & Act
            var result = value.ToKeep(keep);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(null, 2, null)]
        [InlineData(1.2345, 2, 1.23)]
        [InlineData(1.2355, 2, 1.24)]
        [InlineData(-1.236, 2, -1.24)]
        public void ToKeep_DoubleNullable_Works(double? value, int keep, double? expected)
        {
            // Arrange & Act
            var result = value.ToKeep(keep);

            // Assert
            Assert.Equal(expected, result);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ToKeepDecimalNullableData()
        {
            yield return new object[] { null, 2, null };
            yield return new object[] { (decimal?)1.2345, 2, (decimal?)1.23 };
            yield return new object[] { (decimal?)1.2355, 2, (decimal?)1.24 };
            yield return new object[] { (decimal?)-1.236, 2, (decimal?)-1.24 };
        }

        [Theory]
        [MemberData(nameof(ToKeepDecimalNullableData))]
        public void ToKeep_DecimalNullable_Works(decimal? value, int keep, decimal? expected)
        {
            // Arrange & Act
            var result = value.ToKeep(keep);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
