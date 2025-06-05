using System;

namespace Aymadoka.Static.DelegateExtension
{
    public static partial class DelegateExtensions
    {
        /// <summary>
        /// 合并两个委托实例，返回一个新的委托，表示这两个委托的组合
        /// </summary>
        /// <param name="a">第一个委托实例</param>
        /// <param name="b">要组合的第二个委托实例</param>
        /// <returns>合并后的委托实例</returns>
        public static Delegate Combine(this Delegate a, Delegate b)
        {
            return Delegate.Combine(a, b);
        }
    }
}
