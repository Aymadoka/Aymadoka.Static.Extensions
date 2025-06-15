using System;

namespace Aymadoka.Static.DelegateExtension
{
    public static partial class DelegateExtensions
    {
        /// <summary>
        /// 从源委托中移除所有与指定委托匹配的委托实例
        /// </summary>
        /// <param name="source">要从中移除委托的源委托</param>
        /// <param name="value">要移除的委托</param>
        /// <returns>移除所有匹配项后的新委托，如果没有匹配项则返回原始委托；如果结果为空则返回 null</returns>
        public static Delegate? RemoveAll(this Delegate source, Delegate value)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return Delegate.RemoveAll(source, value);
        }
    }
}
