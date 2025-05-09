using Shouldly;
using System;

namespace Aymadoka.Static.EnumExtension
{
    public class EnumExtensionsTests
    { 
        [Fact]
        public void GetEnumValuesWithDescriptions_ShouldReturnAllEnumValuesWithDescriptions()
        {
            // Act
            var result = EnumExtensions.GetEnumValuesWithDescriptions<TestEnum>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
            Assert.Contains(result, item => item.Value == TestEnum.Value1 && item.Description == "Value One");
            Assert.Contains(result, item => item.Value == TestEnum.Value2 && item.Description == "Value Two");
            Assert.Contains(result, item => item.Value == TestEnum.Value3 && item.Description == "Value3");
        }

        [Fact]
        public void GetEnumValuesWithDescriptions_ExtensionMethod_ShouldReturnAllEnumValuesWithDescriptions()
        {
            // Arrange
            var dummyValue = TestEnum.Value1;

            // Act
            var result = dummyValue.GetEnumValuesWithDescriptions();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
            Assert.Contains(result, item => item.Value == TestEnum.Value1 && item.Description == "Value One");
            Assert.Contains(result, item => item.Value == TestEnum.Value2 && item.Description == "Value Two");
            Assert.Contains(result, item => item.Value == TestEnum.Value3 && item.Description == "Value3");
        }

        [Fact]
        public void GetDescription_ShouldReturnDescription_WhenDescriptionAttributeExists()
        {
            // Arrange
            var enumValue = TestEnum.Value1;

            // Act
            var description = enumValue.GetDescription();

            // Assert
            Assert.Equal("Value One", description);
        }

        [Fact]
        public void GetDescription_ShouldReturnEnumName_WhenDescriptionAttributeDoesNotExist()
        {
            // Arrange
            var enumValue = TestEnum.Value3;

            // Act
            var description = enumValue.GetDescription();

            // Assert
            Assert.Equal("Value3", description);
        }

        [Fact]
        public void IsDefined_ShouldReturnTrue_WhenValueIsDefinedInEnum()
        {
            // Arrange
            var enumValue = TestEnum.Value1;

            // Act
            var result = enumValue.IsDefined();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsDefined_ShouldReturnFalse_WhenValueIsNotDefinedInEnum()
        {
            // Arrange
            var invalidValue = (TestEnum)999;

            // Act
            var result = invalidValue.IsDefined();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ParseEnum_ShouldReturnEnumValue_WhenInputIsValid()
        {
            // Arrange
            var input = "Value1";

            // Act
            var result = input.ParseEnum<TestEnum>();

            // Assert
            Assert.Equal(TestEnum.Value1, result);
        }
        
        [Theory]
        [InlineData("VALUE2")]
        [InlineData("VAluE2")]
        [InlineData("value2")]
        public void ParseEnum_ShouldReturnEnumValue_WhenInputIsValidAndIgnoreCaseIsTrue(string input)
        {
            // Act
            var result = input.ParseEnum<TestEnum>(ignoreCase: true);

            // Assert
            Assert.Equal(TestEnum.Value2, result);
        }

        [Fact]
        public void ParseEnum_ShouldThrowArgumentNullException_WhenInputIsNull()
        {
            // Arrange
            string? input = null;

            // Act
            var exception = Record.Exception(() => input.ParseEnum<TestEnum>());
            var argumentNullException = exception as ArgumentNullException;

            // Assert
            Assert.NotNull(argumentNullException);
            Assert.IsType<ArgumentNullException>(argumentNullException);
            Assert.Equal("value", argumentNullException.ParamName);
        }

        [Fact]
        public void ParseEnum_ShouldThrowArgumentException_WhenInputIsInvalid()
        {
            // Arrange
            var input = "InvalidValue";

            // Act
            var exception = Record.Exception(() => input.ParseEnum<TestEnum>());

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<ArgumentException>(exception);
        }

        [Fact]
        public void ParseEnum_ShouldThrowArgumentException_WhenInputIsCaseSensitiveAndIgnoreCaseIsFalse()
        {
            // Arrange
            var input = "value3";

            // Act
            var exception = Record.Exception(() => input.ParseEnum<TestEnum>(ignoreCase: false));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<ArgumentException>(exception);
        }

        [Fact]
        public void GetValues_ShouldReturnAllEnumValues()
        {
            // Act
            var result = EnumExtensions.GetValues<TestEnum>();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(3, result.Length);
            Assert.Contains(TestEnum.Value1, result);
            Assert.Contains(TestEnum.Value2, result);
            Assert.Contains(TestEnum.Value3, result);
        }

        [Fact]
        public void GetValues_ShouldReturnEmptyArray_WhenEnumHasNoValues()
        {
            // Act
            var result = EnumExtensions.GetValues<EmptyEnum>();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void HasFlagsAttribute_ShouldReturnTrue_WhenEnumHasFlagsAttribute()
        {
            // Arrange
            var enumValue = FlagsEnum.Option1;

            // Act
            var result = enumValue.HasFlagsAttribute();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void HasFlagsAttribute_ShouldReturnFalse_WhenEnumDoesNotHaveFlagsAttribute()
        {
            // Arrange
            var enumValue = TestEnum.Value1;

            // Act
            var result = enumValue.HasFlagsAttribute();

            // Assert
            Assert.False(result);
        }
    }
}
