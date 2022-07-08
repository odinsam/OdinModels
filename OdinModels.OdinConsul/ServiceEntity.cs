namespace OdinModels.OdinConsul;

/// <summary>
/// consul server entity
/// </summary>
public class ServiceEntity
{
    /// <summary>
    /// server Protocol
    /// </summary>
    public string ServerProtocol { get; set; } = "http";

    /// <summary>
    /// server ip
    /// </summary>
    public string ServerIP { get; set; } = "localhost";

    /// <summary>
    /// server port
    /// </summary>
    public int ServerPort { get; set; } = new Random().Next(10000, 65535);

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
    /// <summary>
    /// consul Protocol
    /// </summary>
    public string ConsulProtocol { get; set; }
    /// <summary>
    /// consul ip
    /// </summary>
    public string ConsulIP { get; set; }
    /// <summary>
    /// consul port
    /// </summary>
    public int ConsulPort { get; set; }
}