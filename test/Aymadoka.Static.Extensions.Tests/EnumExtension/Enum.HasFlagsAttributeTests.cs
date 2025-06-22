namespace Aymadoka.Static.EnumExtension
{
    public class Enum_HasFlagsAttributeTests
    {
        [Flags]
        private enum TestFlagsEnum
        {
            None = 0,
            First = 1,
            Second = 2
        }

        private enum TestNormalEnum
        {
            A = 0,
            B = 1
        }

        [Fact]
        public void HasFlagsAttribute_ShouldReturnTrue_WhenEnumHasFlagsAttribute()
        {
            var value = TestFlagsEnum.First;
            Assert.True(value.HasFlagsAttribute());
        }

        [Fact]
        public void HasFlagsAttribute_ShouldReturnFalse_WhenEnumDoesNotHaveFlagsAttribute()
        {
            var value = TestNormalEnum.A;
            Assert.False(value.HasFlagsAttribute());
        }
    }
}
