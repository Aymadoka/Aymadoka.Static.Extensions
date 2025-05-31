using System.Globalization;

namespace Aymadoka.Static.CharExtension
{
    public class Char_ToUpperTests
    {
        [Theory]
        [InlineData('a', 'A')]
        [InlineData('z', 'Z')]
        [InlineData('A', 'A')]
        [InlineData('1', '1')]
        [InlineData('é', 'É')]
        public void ToUpper_DefaultCulture_ReturnsUpper(char input, char expected)
        {
            Assert.Equal(expected, input.ToUpper());
        }

        [Theory]
        [InlineData('i', 'İ', "tr-TR")] // 土耳其语小写i转大写İ
        [InlineData('i', 'I', "en-US")]
        [InlineData('ß', 'ß', "de-DE")] // 德语ß转大写SS，但char只能返回第一个字符
        public void ToUpper_WithCulture_ReturnsUpper(char input, char expected, string cultureName)
        {
            var culture = new CultureInfo(cultureName);
            char result = input.ToUpper(culture);


            Assert.Equal(expected, result);
        }
    }
}
