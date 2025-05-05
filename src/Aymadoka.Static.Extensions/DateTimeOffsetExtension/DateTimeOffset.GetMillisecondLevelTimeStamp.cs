using System;

namespace Aymadoka.Static.DateTimeOffsetExtension;

public static partial class DateTimeOffsetExtensions
{
    /// <summary>
    /// 获取 <see cref="DateTimeOffset"/> 的毫秒级时间戳。
    /// </summary>
    /// <param name="this">要获取时间戳的 <see cref="DateTimeOffset"/>。</param>
    /// <returns>毫秒级时间戳。</returns>
    public static long GetMillisecondLevelTimeStamp(this DateTimeOffset @this)
    {
        var result = @this.ToUnixTimeMilliseconds();
        return result;
    }
}
