namespace Aymadoka.Static.NumberExtension
{
    public class Number_ToEvenTests
    {
        [Theory]
        [InlineData(1.235f, 2, 1.24f)]
        [InlineData(1.225f, 2, 1.23f)]
        [InlineData(1.5f, 0, 2f)]
        [InlineData(2.5f, 0, 2f)]
        [InlineData(-1.235f, 2, -1.24f)]
        [InlineData(-1.225f, 2, -1.23f)]
        public void ToEven_Float_Works(float input, int digits, float expected)
        {
            var result = input.ToEven(digits);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1.235, 2, 1.24)]
        [InlineData(1.225, 2, 1.23)]
        [InlineData(1.5, 0, 2)]
        [InlineData(2.5, 0, 2)]
        [InlineData(-1.235, 2, -1.24)]
        [InlineData(-1.225, 2, -1.23)]
        public void ToEven_Double_Works(double input, int digits, double expected)
        {
            var result = input.ToEven(digits);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1.235, 2, 1.24)]
        [InlineData(1.225, 2, 1.22)]
        [InlineData(1.5, 0, 2)]
        [InlineData(2.5, 0, 2)]
        [InlineData(-1.235, 2, -1.24)]
        [InlineData(-1.225, 2, -1.22)]
        public void ToEven_Decimal_Works(decimal input, int digits, decimal expected)
        {
            var result = input.ToEven(digits);
            Assert.Equal(expected, result);
        }
    }
}
