namespace OdinModels.Constants;

/// <summary>
/// 系统常量
/// </summary>
public class SystemConstant
{
    #region 基础常量
    public const string KEY_OF_HTTPS = "https";
    public const string KEY_OF_HTTP = "http";
    

    #endregion
    
    #region Config配置常量
    public const string KEY_OF_CONNECTIONSTRING_SECTION = "ConnectionStrings";
    
    public const string KEY_OF_ODINLOGS_SECTION = "OdinLogs";
    public const string KEY_OF_ODINLOGS_DBTYPE_SECTION = "OdinLogs:DbType";
    public const string KEY_OF_ODINLOGS_SAVETYPE_SECTION = "OdinLogs:SaveType";
    
    public const string KEY_OF_SERVICE_PROTOCOL_SECTION = "Service:Protocol";
    public const string KEY_OF_SERVICE_IP_SECTION = "Service:ip";
    public const string KEY_OF_SERVICE_PORT_SECTION = "Service:Port";
    /// <summary>
    /// OdinApplication 配置常量
    /// </summary>
    public const string KEY_OF_ODINAPPLICATION_SECTION = "OdinApplication";

    #region redis

    public const string KEY_OF_WRITESERVERLIST_REDIS_SECTION = "Redis:WriteServerList";
    public const string KEY_OF_READSERVERLIST_REDIS_SECTION = "Redis:ReadServerList";
    public const string KEY_OF_MAXWRITEPOOLSIZE_REDIS_SECTION = "Redis:MaxWritePoolSize";
    public const string KEY_OF_MAXREADPOOLSIZE_REDIS_SECTION = "Redis:MaxReadPoolSize";
    public const string KEY_OF_LOCALCACHETIME_REDIS_SECTION = "Redis:LocalCacheTime";
    public const string KEY_OF_AUTOSTART_REDIS_SECTION = "Redis:AutoStart";
    public const string KEY_OF_RECORDELOG_REDIS_SECTION = "Redis:RecordeLog";

    #endregion
    
    #endregion
    
    #region OpenApi 常量
    public const string KEY_OF_HEALTH_CHECK_PATH = "/health";
    public  const string KEY_OF_APPLICATION_CONTENT_TYPE = "application/json";
    #endregion

}