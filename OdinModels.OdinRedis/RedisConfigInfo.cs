using Microsoft.Extensions.Configuration;
using OdinModels.Constants;
using OdinMSA.Core.Extensions;

namespace OdinModels.OdinRedis;

public class RedisConfigInfo
{
    public static IConfiguration Config { get; set; }
    /// <summary>
    /// 可写的Redis链接地址
    /// format:ip1,ip2
    /// 默认6379端口
    ///
    /// 如果有密码按下面格式填写
    /// password@ip:port
    /// </summary>
    public string WriteServerList = Config.GetSectionValue<string>(SystemConstant
    .KEY_OF_WRITESERVERLIST_REDIS_SECTION);

    /// <summary>
    /// 可读的Redis链接地址
    /// format:ip1,ip2
    /// </summary>
    public string ReadServerList = Config.GetSectionValue<string>(SystemConstant.KEY_OF_READSERVERLIST_REDIS_SECTION);

    /// <summary>
    /// 最大写链接数
    /// </summary>
    public int MaxWritePoolSize =
        int.Parse(Config.GetSectionValue<string>(SystemConstant.KEY_OF_MAXWRITEPOOLSIZE_REDIS_SECTION) ?? "60");

    /// <summary>
    /// 最大读链接数
    /// </summary>
    public int MaxReadPoolSize =
        int.Parse(Config.GetSectionValue<string>(SystemConstant.KEY_OF_MAXREADPOOLSIZE_REDIS_SECTION) ?? "60");

    /// <summary>
    /// 本地缓存到期时间，单位:秒
    /// </summary>
    public int LocalCacheTime =
        int.Parse(Config.GetSectionValue<string>(SystemConstant.KEY_OF_LOCALCACHETIME_REDIS_SECTION) ?? "180");

    /// <summary>
    /// 自动重启
    /// </summary>
    public bool AutoStart =
        bool.Parse(Config.GetSectionValue<string>(SystemConstant.KEY_OF_AUTOSTART_REDIS_SECTION) ?? "true");

    /// <summary>
    /// 是否记录日志,该设置仅用于排查redis运行时出现的问题,
    /// 如redis工作正常,请关闭该项
    /// </summary>
    public bool RecordeLog = bool.Parse(Config.GetSectionValue<string>(SystemConstant
    .KEY_OF_RECORDELOG_REDIS_SECTION)??"false");
}