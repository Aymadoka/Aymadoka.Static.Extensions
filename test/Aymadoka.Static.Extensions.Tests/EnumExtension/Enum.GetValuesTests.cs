namespace Aymadoka.Static.EnumExtension
{
    public class Enum_GetValuesTests
    {
        private enum SampleEnum
        {
            First = 1,
            Second = 2,
            Third = 3
        }
        enum EmptyEnum { }

        [Fact]
        public void GetValues_ReturnsAllEnumValues()
        {
            // Act
            var values = EnumExtensions.GetValues<SampleEnum>();

            // Assert
            Assert.Equal(3, values.Length);
            Assert.Contains(SampleEnum.First, values);
            Assert.Contains(SampleEnum.Second, values);
            Assert.Contains(SampleEnum.Third, values);
        }

        [Fact]
        public void GetValues_ReturnsEmptyArrayForEmptyEnum()
        {
            // Arrange


            // Act
            var values = EnumExtensions.GetValues<EmptyEnum>();

            // Assert
            Assert.Empty(values);
        }
    }
}
