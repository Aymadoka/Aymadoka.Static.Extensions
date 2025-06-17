namespace Aymadoka.Static.StringExtension
{
    public class String_ToEnumTests
    {
        public enum SampleEnum
        {
            FirstValue,
            SecondValue,
            ThirdValue
        }

        [Theory]
        [InlineData("FirstValue", SampleEnum.FirstValue)]
        [InlineData("SecondValue", SampleEnum.SecondValue)]
        [InlineData("ThirdValue", SampleEnum.ThirdValue)]
        public void ToEnum_ValidString_ReturnsExpectedEnum(string input, SampleEnum expected)
        {
            var result = input.ToEnum<SampleEnum>();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToEnum_InvalidString_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => "InvalidValue".ToEnum<SampleEnum>());
        }

        [Fact]
        public void ToEnum_NullString_ThrowsArgumentNullException()
        {
            string input = null;
            Assert.Throws<ArgumentNullException>(() => input.ToEnum<SampleEnum>());
        }
    }
}
