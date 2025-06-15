namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 如果当前对象与指定值相等，则返回 null；否则返回当前对象本身。
        /// </summary>
        /// <typeparam name="T">引用类型。</typeparam>
        /// <param name="this">当前对象。</param>
        /// <param name="value">要比较的值。</param>
        /// <returns>如果相等返回 null，否则返回当前对象。</returns>
        public static T? NullIfEquals<T>(this T @this, T value) where T : class
        {
            if (@this.Equals(value))
            {
                return null;
            }

            return @this;
        }
    }
}
