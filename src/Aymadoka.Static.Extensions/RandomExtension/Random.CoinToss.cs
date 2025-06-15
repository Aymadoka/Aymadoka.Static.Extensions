using System;

namespace Aymadoka.Static.RandomExtension
{
    public static partial class RandomExtensions
    {
        /// <summary>
        /// 扩展方法：模拟抛硬币，返回 true 或 false，概率各为 50%。
        /// </summary>
        /// <param name="this">要扩展的 <see cref="Random"/> 实例。</param>
        /// <returns>抛硬币结果，true 或 false。</returns>
        public static bool CoinToss(this Random @this)
        {
            return @this.Next(2) == 0;
        }
    }
}
