namespace Aymadoka.Static.EnumExtension
{
    public class Enum_ParseEnumTests
    {
        private enum SampleEnum
        {
            FirstValue,
            SecondValue,
            ThirdValue
        }

        [Fact]
        public void ParseEnum_ValidString_ReturnsEnumValue()
        {
            var result = "FirstValue".ParseEnum<SampleEnum>();
            Assert.Equal(SampleEnum.FirstValue, result);
        }

        [Fact]
        public void ParseEnum_ValidString_IgnoreCase_ReturnsEnumValue()
        {
            var result = "secondvalue".ParseEnum<SampleEnum>(ignoreCase: true);
            Assert.Equal(SampleEnum.SecondValue, result);
        }

        [Fact]
        public void ParseEnum_ValidString_CaseSensitive_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => "secondvalue".ParseEnum<SampleEnum>(ignoreCase: false));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void ParseEnum_NullOrWhiteSpace_ThrowsArgumentNullException(string input)
        {
            Assert.Throws<ArgumentNullException>(() => input.ParseEnum<SampleEnum>());
        }

        [Fact]
        public void ParseEnum_InvalidValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => "NotExist".ParseEnum<SampleEnum>());
        }
    }
}
