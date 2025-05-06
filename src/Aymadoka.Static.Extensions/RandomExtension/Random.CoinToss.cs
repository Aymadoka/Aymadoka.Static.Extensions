using System;

namespace Aymadoka.Static.RandomExtension
{
    public static partial class RandomExtensions
    {
        public static bool CoinToss(this Random @this)
        {
            return @this.Next(2) == 0;
        }
    }
}
