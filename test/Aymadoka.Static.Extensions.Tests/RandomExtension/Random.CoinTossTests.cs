namespace Aymadoka.Static.RandomExtension
{
    public class Random_CoinTossTests
    {
        [Fact]
        public void CoinToss_ShouldReturnBoolean()
        {
            var random = new Random();
            var result = random.CoinToss();
            Assert.IsType<bool>(result);
        }

        [Fact]
        public void CoinToss_ShouldReturnTrueOrFalse()
        {
            var random = new Random();
            bool hasTrue = false;
            bool hasFalse = false;

            // 多次抛硬币，确保能出现 true 和 false
            for (int i = 0; i < 100; i++)
            {
                var result = random.CoinToss();
                if (result) hasTrue = true;
                else hasFalse = true;

                if (hasTrue && hasFalse) break;
            }

            Assert.True(hasTrue, "CoinToss 未返回 true");
            Assert.True(hasFalse, "CoinToss 未返回 false");
        }
    }
}
