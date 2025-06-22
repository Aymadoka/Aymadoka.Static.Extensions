using System;

namespace Aymadoka.Static.EventHandlerExtension
{
    public static partial class EventHandlerExtensions
    {
        /// <summary>
        /// 触发无指定发送者的事件。
        /// </summary>
        /// <param name="this">事件处理器。</param>
        /// <param name="e">事件参数。</param>
        public static void RaiseEvent(this EventHandler @this, EventArgs e)
        {
            @this?.Invoke(null, e);
        }

        /// <summary>
        /// 触发带有指定发送者的事件。
        /// </summary>
        /// <param name="handler">事件处理器。</param>
        /// <param name="sender">事件发送者。</param>
        /// <param name="e">事件参数。</param>
        public static void RaiseEvent(this EventHandler handler, object sender, EventArgs e)
        {
            handler?.Invoke(sender, e);
        }

        /// <summary>
        /// 触发带有指定发送者的泛型事件，事件参数自动实例化。
        /// </summary>
        /// <typeparam name="TEventArgs">事件参数类型。</typeparam>
        /// <param name="this">事件处理器。</param>
        /// <param name="sender">事件发送者。</param>
        public static void RaiseEvent<TEventArgs>(this EventHandler<TEventArgs> @this, object sender) where TEventArgs : EventArgs
        {
            @this?.Invoke(sender, Activator.CreateInstance<TEventArgs>());
        }

        /// <summary>
        /// 触发带有指定发送者和参数的泛型事件。
        /// </summary>
        /// <typeparam name="TEventArgs">事件参数类型。</typeparam>
        /// <param name="this">事件处理器。</param>
        /// <param name="sender">事件发送者。</param>
        /// <param name="e">事件参数。</param>
        public static void RaiseEvent<TEventArgs>(this EventHandler<TEventArgs> @this, object sender, TEventArgs e) where TEventArgs : EventArgs
        {
            @this?.Invoke(sender, e);
        }
    }
}
