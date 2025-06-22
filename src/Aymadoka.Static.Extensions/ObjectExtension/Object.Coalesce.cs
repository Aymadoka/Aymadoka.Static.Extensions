namespace Aymadoka.Static.ObjectExtension
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// 返回当前对象本身（如果不为 null），否则返回参数列表中第一个不为 null 的值。
        /// </summary>
        /// <typeparam name="T">引用类型。</typeparam>
        /// <param name="this">要判断的对象。</param>
        /// <param name="values">备用对象列表。</param>
        /// <returns>第一个不为 null 的对象，如果都为 null，则返回 null。</returns>
        public static T? Coalesce<T>(this T? @this, params T[] values) where T : class
        {
            if (@this != null)
            {
                return @this;
            }

            foreach (T value in values)
            {
                if (value != null)
                {
                    return value;
                }
            }

            return null;
        }
    }
}
