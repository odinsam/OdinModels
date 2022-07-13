namespace OdinModels.Core.ConfigModels;

/// <summary>
/// 服务基础配置
/// </summary>
public class UrlConfig
{
    /// <summary>
    /// 服务协议
    /// </summary>
    public string Protocol { get; set; }
    /// <summary>
    /// 服务ip
    /// </summary>
    public string Ip { get; set; }
    /// <summary>
    /// 服务端口
    /// </summary>
    public string Port { get; set; }

}