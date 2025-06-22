namespace Aymadoka.Static.NumberExtension
{
    public class Number_IsPositiveInfinityTests
    {
        [Theory]
        [InlineData(float.PositiveInfinity, true)]
        [InlineData(float.NegativeInfinity, false)]
        [InlineData(0f, false)]
        [InlineData(float.NaN, false)]
        [InlineData(1.23f, false)]
        public void IsPositiveInfinity_Float_ReturnsExpected(float value, bool expected)
        {
            var result = value.IsPositiveInfinity();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(double.PositiveInfinity, true)]
        [InlineData(double.NegativeInfinity, false)]
        [InlineData(0d, false)]
        [InlineData(double.NaN, false)]
        [InlineData(1.23d, false)]
        public void IsPositiveInfinity_Double_ReturnsExpected(double value, bool expected)
        {
            var result = value.IsPositiveInfinity();
            Assert.Equal(expected, result);
        }
    }
}
