using OdinModels.OdinUtils.OdinExtensions;

namespace OdinModels.OdinConsul;

public class ConsulConfig
{
    /// <summary>
    /// consul Protocol
    /// </summary>
    public string Protocol { get; set; }
    /// <summary>
    /// consul ip
    /// </summary>
    public string IP { get; set; }
    /// <summary>
    /// consul port
    /// </summary>
    public int Port { get; set; }

    public string GetConsulUrl()
    {
        var uri = $"{Protocol}://{IP}";
        var port = $":{Port}";
        if (Protocol.CompareString("http") && Port == 80)
            port = "";
        if (Protocol.CompareString("https") && Port == 443)
            port = "";
        return $"{Protocol}://{IP}{port}";
    }
}