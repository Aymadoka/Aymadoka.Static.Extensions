using System;

namespace Aymadoka.Static.BooleanExtension
{
    public static partial class BooleanExtensions
    {
        /// <summary>
        /// 当布尔值为 <c>false</c> 时，执行指定的 <paramref name="action"/> 委托
        /// </summary>
        /// <param name="this">要判断的布尔值</param>
        /// <param name="action">当 <paramref name="this"/> 为 <c>false</c> 时要执行的操作</param>
        /// <remarks>
        /// 如果 <paramref name="this"/> 为 <c>true</c>，则不会执行 <paramref name="action"/>
        /// </remarks>
        /// <example>
        /// <code>
        /// bool condition = false;
        /// condition.IfFalse(() => Console.WriteLine("条件为 false"));
        /// // 输出: 条件为 false
        /// </code>
        /// </example>
        public static void IfFalse(this bool @this, Action action)
        {
            if (!@this)
            {
                if (action == null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action();
            }
        }
    }
}
