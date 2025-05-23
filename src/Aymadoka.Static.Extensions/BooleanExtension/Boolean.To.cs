namespace Aymadoka.Static.BooleanExtension
{
    public static partial class BooleanExtensions
    {
        /// <summary>
        /// 根据布尔值返回指定的 trueValue 或 falseValue
        /// </summary>
        /// <typeparam name="T">返回值的类型</typeparam>
        /// <param name="this">布尔值实例</param>
        /// <param name="trueValue">当布尔值为 true 时返回的值</param>
        /// <param name="falseValue">当布尔值为 false 时返回的值</param>
        /// <returns>如果 <paramref name="this"/> 为 true，则返回 <paramref name="trueValue"/>；否则返回 <paramref name="falseValue"/></returns>
        public static T To<T>(this bool @this, T trueValue, T falseValue)
        {
            return @this ? trueValue : falseValue;
        }
    }
}
