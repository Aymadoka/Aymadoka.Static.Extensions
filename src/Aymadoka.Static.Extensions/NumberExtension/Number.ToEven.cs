using System;

namespace Aymadoka.Static.NumberExtension
{
    public static partial class NumberExtensions
    {
        /// <summary>使用银行家算法的方式保留指定的小数位</summary>
        /// <param name="source">需要处理的原始小数值</param>
        /// <param name="keepPlaceCount">需要保留的小数位数</param>
        /// <returns>保留指定小数位后的结果</returns>
        public static float ToEven(this float source, int keepPlaceCount = 2)
        {
            var result = (float)Math.Round(source, keepPlaceCount, MidpointRounding.ToEven);
            return result;
        }

        /// <summary>使用银行家算法的方式保留指定的小数位</summary>
        /// <param name="source">需要处理的原始小数值</param>
        /// <param name="keepPlaceCount">需要保留的小数位数</param>
        /// <returns>保留指定小数位后的结果</returns>
        public static double ToEven(this double source, int keepPlaceCount = 2)
        {
            var result = Math.Round(source, keepPlaceCount, MidpointRounding.ToEven);
            return result;
        }

        /// <summary>使用银行家算法的方式保留指定的小数位</summary>
        /// <param name="source">需要处理的原始小数值</param>
        /// <param name="keepPlaceCount">需要保留的小数位数</param>
        /// <returns>保留指定小数位后的结果</returns>
        public static decimal ToEven(this decimal source, int keepPlaceCount = 2)
        {
            var result = Math.Round(source, keepPlaceCount, MidpointRounding.ToEven);
            return result;
        }
    }
}
