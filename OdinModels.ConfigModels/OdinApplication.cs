namespace OdinModels.ConfigModels;

public class OdinApplication
{
    /// <summary>
    /// 服务名称
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// 服务协议
    /// </summary>
    public string Protocol { get; set; }
    /// <summary>
    /// 服务Host
    /// </summary>
    public string Host { get; set; }
    /// <summary>
    /// 服务Port
    /// </summary>
    public int Port { get; set; }
}