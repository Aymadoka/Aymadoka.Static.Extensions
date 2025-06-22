using Aymadoka.Static.NumberExtension;
using System.Diagnostics.CodeAnalysis;

namespace Aymadoka.Static.NumberExtension
{
    public class Number_BetweenTests
    {
        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> SByteBetweenData()
        {
            yield return new object[] { (sbyte)5, (sbyte)1, (sbyte)9, true };
            yield return new object[] { (sbyte)1, (sbyte)1, (sbyte)9, false };
            yield return new object[] { (sbyte)9, (sbyte)1, (sbyte)9, false };
            yield return new object[] { (sbyte)0, (sbyte)-5, (sbyte)0, false };
        }

        [Theory]
        [MemberData(nameof(SByteBetweenData))]
        public void SByte_Between_Test(sbyte value, sbyte min, sbyte max, bool expected)
        {
            var act = value.Between(min, max);
            Assert.Equal(expected, act);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ByteBetweenData()
        {
            yield return new object[] { (byte)5, (byte)1, (byte)9, true };
            yield return new object[] { (byte)1, (byte)1, (byte)9, false };
            yield return new object[] { (byte)9, (byte)1, (byte)9, false };
        }

        [Theory]
        [MemberData(nameof(ByteBetweenData))]
        public void Byte_Between_Test(byte value, byte min, byte max, bool expected)
        {
            var act = value.Between(min, max);
            Assert.Equal(expected, act);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> ShortBetweenData()
        {
            yield return new object[] { (short)5, (short)1, (short)9, true };
            yield return new object[] { (short)1, (short)1, (short)9, false };
            yield return new object[] { (short)9, (short)1, (short)9, false };
        }

        [Theory]
        [MemberData(nameof(ShortBetweenData))]
        public void Short_Between_Test(short value, short min, short max, bool expected)
        {
            var act = value.Between(min, max);
            Assert.Equal(expected, act);
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> UShortBetweenData()
        {
            yield return new object[] { (ushort)5, (ushort)1, (ushort)9, true };
            yield return new object[] { (ushort)1, (ushort)1, (ushort)9, false };
            yield return new object[] { (ushort)9, (ushort)1, (ushort)9, false };
        }

        [Theory]
        [MemberData(nameof(UShortBetweenData))]
        public void UShort_Between_Test(ushort value, ushort min, ushort max, bool expected)
        {
            var act = value.Between(min, max);
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData(5, 1, 10, true)]
        [InlineData(1, 1, 10, false)]
        [InlineData(10, 1, 10, false)]
        public void Int_Between_Test(int value, int min, int max, bool expected)
        {
            var act = value.Between(min, max);
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData(5u, 1u, 10u, true)]
        [InlineData(1u, 1u, 10u, false)]
        [InlineData(10u, 1u, 10u, false)]
        public void UInt_Between_Test(uint value, uint min, uint max, bool expected)
        {
            var act = value.Between(min, max);
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData(5L, 1L, 10L, true)]
        [InlineData(1L, 1L, 10L, false)]
        [InlineData(10L, 1L, 10L, false)]
        public void Long_Between_Test(long value, long min, long max, bool expected)
        {
            var act = value.Between(min, max);
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData(5ul, 1ul, 10ul, true)]
        [InlineData(1ul, 1ul, 10ul, false)]
        [InlineData(10ul, 1ul, 10ul, false)]
        public void ULong_Between_Test(ulong value, ulong min, ulong max, bool expected)
        {
            var act = value.Between(min, max);
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData(5.5f, 1.1f, 10.2f, true)]
        [InlineData(1.1f, 1.1f, 10.2f, false)]
        [InlineData(10.2f, 1.1f, 10.2f, false)]
        [InlineData(0f, -1f, 1f, true)]
        public void Float_Between_Test(float value, float min, float max, bool expected)
        {
            var act = value.Between(min, max);
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData(5.5, 1.1, 10.2, true)]
        [InlineData(1.1, 1.1, 10.2, false)]
        [InlineData(10.2, 1.1, 10.2, false)]
        [InlineData(0.0, -1.0, 1.0, true)]
        public void Double_Between_Test(double value, double min, double max, bool expected)
        {
            var act = value.Between(min, max);
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData(5.5, 1.1, 10.2, true)]
        [InlineData(1.1, 1.1, 10.2, false)]
        [InlineData(10.2, 1.1, 10.2, false)]
        [InlineData(0.0, -1.0, 1.0, true)]
        public void Decimal_Between_Test(decimal value, decimal min, decimal max, bool expected)
        {
            var act = value.Between(min, max);
            Assert.Equal(expected, act);
        }
    }
}
