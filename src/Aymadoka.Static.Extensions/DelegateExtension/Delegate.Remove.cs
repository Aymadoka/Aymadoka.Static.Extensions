using System;

namespace Aymadoka.Static.DelegateExtension
{
    public static partial class DelegateExtensions
    {
        /// <summary>
        /// 从当前委托中移除与指定委托（value）相同的最后一个委托实例
        /// </summary>
        /// <param name="source">要从中移除委托的源委托</param>
        /// <param name="value">要移除的委托实例</param>
        /// <returns>移除指定委托后的新委托，如果未找到则返回原委托</returns>
        public static Delegate? Remove(this Delegate source, Delegate value)
        {
            return Delegate.Remove(source, value);
        }
    }
}
