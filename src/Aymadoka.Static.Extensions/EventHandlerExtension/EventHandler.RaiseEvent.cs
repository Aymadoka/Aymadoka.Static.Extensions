using System;

namespace Aymadoka.Static.EventHandlerExtension
{
    public static partial class EventHandlerExtensions
    {
        public static void RaiseEvent(this EventHandler @this, EventArgs e)
        {
            @this?.Invoke(null, e);
        }

        public static void RaiseEvent(this EventHandler handler, object sender, EventArgs e)
        {
            handler?.Invoke(sender, e);
        }

        public static void RaiseEvent<TEventArgs>(this EventHandler<TEventArgs> @this, object sender) where TEventArgs : EventArgs
        {
            @this?.Invoke(sender, Activator.CreateInstance<TEventArgs>());
        }

        public static void RaiseEvent<TEventArgs>(this EventHandler<TEventArgs> @this, object sender, TEventArgs e) where TEventArgs : EventArgs
        {
            @this?.Invoke(sender, e);
        }
    }
}
