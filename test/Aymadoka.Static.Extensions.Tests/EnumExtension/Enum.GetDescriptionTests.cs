using System.ComponentModel;

namespace Aymadoka.Static.EnumExtension
{
    public class Enum_GetDescriptionTests
    {
        private enum TestEnum
        {
            [Description("描述A")]
            ValueA,
            [Description("描述B")]
            ValueB,
            ValueC // 无Description
        }

        [Fact]
        public void GetDescription_WithDescriptionAttribute_ReturnsDescription()
        {
            var desc = TestEnum.ValueA.GetDescription();
            Assert.Equal("描述A", desc);
        }

        [Fact]
        public void GetDescription_WithoutDescriptionAttribute_ReturnsEnumName()
        {
            var desc = TestEnum.ValueC.GetDescription();
            Assert.Equal("ValueC", desc);
        }
    }
}
