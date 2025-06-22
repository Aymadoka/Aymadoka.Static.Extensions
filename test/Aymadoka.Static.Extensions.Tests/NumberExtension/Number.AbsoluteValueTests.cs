using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NumberExtension
{
    public class Number_AbsoluteValueTests
    {
        [Theory]
        [InlineData((sbyte)-1, (sbyte)1)]
        [InlineData((sbyte)0, (sbyte)0)]
        [InlineData((sbyte)1, (sbyte)1)]
        public void AbsoluteValue_SByte_Works(sbyte input, sbyte expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [Theory]
        [InlineData((byte)0, (short)0)]
        [InlineData((byte)1, (short)1)]
        [InlineData(byte.MaxValue, (short)255)]
        public void AbsoluteValue_Byte_Works(byte input, short expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [Theory]
        [InlineData((short)-1, (short)1)]
        [InlineData((short)0, (short)0)]
        [InlineData((short)1, (short)1)]
        public void AbsoluteValue_Short_Works(short input, short expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [Theory]
        [InlineData((ushort)0, 0)]
        [InlineData((ushort)1, 1)]
        [InlineData(ushort.MaxValue, 65535)]
        public void AbsoluteValue_UShort_Works(ushort input, int expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> AbsoluteValueIntWorksData()
        {
            yield return new object[] { -2147483647, 2147483647 };
            yield return new object[] { -1, 1 };
            yield return new object[] { 0, 0 };
            yield return new object[] { 1, 1 };
        }

        [Theory]
        [MemberData(nameof(AbsoluteValueIntWorksData))]
        public void AbsoluteValue_Int_Works(int input, int expected)
        {
            var act = input.AbsoluteValue();
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData((uint)0, 0L)]
        [InlineData((uint)1, 1L)]
        [InlineData(uint.MaxValue, 4294967295L)]
        public void AbsoluteValue_UInt_Works(uint input, long expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> AbsoluteValueLongWorksData()
        {
            yield return new object[] { -9223372036854775807L, 9223372036854775807L };
            yield return new object[] { -1L, 1L };
            yield return new object[] { 0L, 0L };
            yield return new object[] { 1L, 1L };
        }

        [Theory]
        [MemberData(nameof(AbsoluteValueLongWorksData))]
        public void AbsoluteValue_Long_Works(long input, long expected)
        {
            var act = input.AbsoluteValue();
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData(-1.5f, 1.5f)]
        [InlineData(0f, 0f)]
        [InlineData(1.5f, 1.5f)]
        public void AbsoluteValue_Float_Works(float input, float expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [Theory]
        [InlineData(-1.5, 1.5)]
        [InlineData(0.0, 0.0)]
        [InlineData(1.5, 1.5)]
        public void AbsoluteValue_Double_Works(double input, double expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }

        [Theory]
        [InlineData(-1.5, 1.5)]
        [InlineData(0.0, 0.0)]
        [InlineData(1.5, 1.5)]
        public void AbsoluteValue_Decimal_Works(decimal input, decimal expected)
        {
            Assert.Equal(expected, input.AbsoluteValue());
        }
    }
}
