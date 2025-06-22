namespace Aymadoka.Static.NumberExtension
{
    public class Number_IsNegativeInfinityTests
    {
        [Fact]
        public void Float_IsNegativeInfinity_ReturnsTrueForNegativeInfinity()
        {
            float value = float.NegativeInfinity;
            Assert.True(value.IsNegativeInfinity());
        }

        [Fact]
        public void Float_IsNegativeInfinity_ReturnsFalseForPositiveInfinity()
        {
            float value = float.PositiveInfinity;
            Assert.False(value.IsNegativeInfinity());
        }

        [Fact]
        public void Float_IsNegativeInfinity_ReturnsFalseForNaN()
        {
            float value = float.NaN;
            Assert.False(value.IsNegativeInfinity());
        }

        [Fact]
        public void Float_IsNegativeInfinity_ReturnsFalseForNormalValue()
        {
            float value = -123.45f;
            Assert.False(value.IsNegativeInfinity());
        }

        [Fact]
        public void Double_IsNegativeInfinity_ReturnsTrueForNegativeInfinity()
        {
            double value = double.NegativeInfinity;
            Assert.True(value.IsNegativeInfinity());
        }

        [Fact]
        public void Double_IsNegativeInfinity_ReturnsFalseForPositiveInfinity()
        {
            double value = double.PositiveInfinity;
            Assert.False(value.IsNegativeInfinity());
        }

        [Fact]
        public void Double_IsNegativeInfinity_ReturnsFalseForNaN()
        {
            double value = double.NaN;
            Assert.False(value.IsNegativeInfinity());
        }

        [Fact]
        public void Double_IsNegativeInfinity_ReturnsFalseForNormalValue()
        {
            double value = -9876.543;
            Assert.False(value.IsNegativeInfinity());
        }
    }
}
