using System;

namespace Aymadoka.Static.BooleanExtension
{
    public static partial class BooleanExtensions
    {
        /// <summary>
        /// 如果布尔值为 <c>true</c>，则执行指定的 <paramref name="action"/>
        /// </summary>
        /// <param name="this">要判断的布尔值</param>
        /// <param name="action">当布尔值为 <c>true</c> 时要执行的操作</param>
        public static void IfTrue(this bool @this, Action action)
        {
            if (@this)
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
