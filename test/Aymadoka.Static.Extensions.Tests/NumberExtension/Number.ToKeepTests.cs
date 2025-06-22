namespace Aymadoka.Static.NumberExtension
{
    public class Number_ToKeepTests
    {
        [Theory]
        [InlineData(1.2345f, 2, 1.23f)]
        [InlineData(1.2355f, 2, 1.24f)]
        [InlineData(-1.2355f, 2, -1.24f)]
        [InlineData(1.2f, 0, 1f)]
        [InlineData(1.5f, 0, 2f)]
        public void ToKeep_Float_Works(float input, int keep, float expected)
        {
            var result = input.ToKeep(keep);
            Assert.Equal(expected, result, 2);
        }

        [Theory]
        [InlineData(1.2345, 2, 1.23)]
        [InlineData(1.2355, 2, 1.24)]
        [InlineData(-1.2355, 2, -1.24)]
        [InlineData(1.2, 0, 1)]
        [InlineData(1.5, 0, 2)]
        public void ToKeep_Double_Works(double input, int keep, double expected)
        {
            var result = input.ToKeep(keep);
            Assert.Equal(expected, result, 2);
        }

        [Theory]
        [InlineData(1.2345, 2, 1.23)]
        [InlineData(1.2355, 2, 1.24)]
        [InlineData(-1.2355, 2, -1.24)]
        [InlineData(1.2, 0, 1)]
        [InlineData(1.5, 0, 2)]
        public void ToKeep_Decimal_Works(decimal input, int keep, decimal expected)
        {
            var result = input.ToKeep(keep);
            Assert.Equal(expected, result);
        }
    }
}
