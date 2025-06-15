namespace Aymadoka.Static.NumberExtension
{
    public class Number_IsInfinityTests
    {
        [Theory]
        [InlineData(float.PositiveInfinity, true)]
        [InlineData(float.NegativeInfinity, true)]
        [InlineData(0f, false)]
        [InlineData(1.23f, false)]
        [InlineData(float.NaN, false)]
        public void IsInfinity_Float_ReturnsExpected(float value, bool expected)
        {
            Assert.Equal(expected, value.IsInfinity());
        }

        [Theory]
        [InlineData(double.PositiveInfinity, true)]
        [InlineData(double.NegativeInfinity, true)]
        [InlineData(0d, false)]
        [InlineData(1.23d, false)]
        [InlineData(double.NaN, false)]
        public void IsInfinity_Double_ReturnsExpected(double value, bool expected)
        {
            Assert.Equal(expected, value.IsInfinity());
        }
    }
}
