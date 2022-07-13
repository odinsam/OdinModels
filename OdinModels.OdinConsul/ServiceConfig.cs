namespace OdinModels.OdinConsul;

/// <summary>
/// consul server entity
/// </summary>
public class ServiceConfig
{
    /// <summary>
    /// consul register id
    /// </summary>
    public string RegisterId { get; set; }
    /// <summary>
    /// 健康检查地址
    /// </summary>
    public string HealthUrl { get; set; }
    /// <summary>
    /// 服务启动多久后注册  单位: 秒
    /// </summary>
    public int DeregisterCriticalServiceAfter { get; set; } = 5;
    /// <summary>
    /// 健康检查时间间隔，或者称为心跳间隔
    /// </summary>
    public int HealInterval { get; set; } = 10;
    /// <summary>
    /// 服务超时时间 单位: 秒
    /// </summary>
    public int TimeOut { get; set; } = 10;
    /// <summary>
    /// server name
    /// </summary>
    public string ServiceName { get; set; }
    /// <summary>
    /// server name
    /// </summary>
    public string[] Tags { get; set; }
}