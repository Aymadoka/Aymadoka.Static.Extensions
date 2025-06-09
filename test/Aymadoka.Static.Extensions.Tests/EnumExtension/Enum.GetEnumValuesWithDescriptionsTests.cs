using System.ComponentModel;

namespace Aymadoka.Static.EnumExtension
{
    public class Enum_GetEnumValuesWithDescriptionsTests
    {
        public enum TestEnum
        {
            [Description("第一个值")]
            First = 1,
            [Description("第二个值")]
            Second = 2,
            Third = 3 // 没有 Description
        }

        [Fact]
        public void GetEnumValuesWithDescriptions_StaticMethod_ReturnsAllValuesWithDescriptions()
        {
            var result = EnumExtensions.GetEnumValuesWithDescriptions<TestEnum>();

            Assert.Equal(3, result.Count);
            Assert.Contains(result, x => x.Value == TestEnum.First && x.Description == "第一个值");
            Assert.Contains(result, x => x.Value == TestEnum.Second && x.Description == "第二个值");
            Assert.Contains(result, x => x.Value == TestEnum.Third && x.Description == nameof(TestEnum.Third));
        }

        [Fact]
        public void GetEnumValuesWithDescriptions_ExtensionMethod_ReturnsAllValuesWithDescriptions()
        {
            var value = TestEnum.Second;
            var result = value.GetEnumValuesWithDescriptions();

            Assert.Equal(3, result.Count);
            Assert.Contains(result, x => x.Value == TestEnum.First && x.Description == "第一个值");
            Assert.Contains(result, x => x.Value == TestEnum.Second && x.Description == "第二个值");
            Assert.Contains(result, x => x.Value == TestEnum.Third && x.Description == nameof(TestEnum.Third));
        }
    }
}
