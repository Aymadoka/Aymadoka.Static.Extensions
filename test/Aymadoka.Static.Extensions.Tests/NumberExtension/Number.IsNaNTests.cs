namespace Aymadoka.Static.NumberExtension
{
    public class Number_IsNaNTests
    {
        [Fact]
        public void IsNaN_Float_NaN_ReturnsTrue()
        {
            float value = float.NaN;
            Assert.True(value.IsNaN());
        }

        [Fact]
        public void IsNaN_Float_Number_ReturnsFalse()
        {
            float value = 1.23f;
            Assert.False(value.IsNaN());
        }

        [Fact]
        public void IsNaN_Double_NaN_ReturnsTrue()
        {
            double value = double.NaN;
            Assert.True(value.IsNaN());
        }

        [Fact]
        public void IsNaN_Double_Number_ReturnsFalse()
        {
            double value = 4.56;
            Assert.False(value.IsNaN());
        }
    }
}
